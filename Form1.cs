using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;

//using PacketDotNet; // http://sourceforge.net/apps/mediawiki/packetnet/index.php?title=Main_Page

namespace LOIC
{
	public partial class frmPacketSettings : Form
	{
		public frmPacketSettings()
		{
			InitializeComponent();
		}

		public static bool IsValidIP(string ipAddress)
		{
			IPAddress unused;
			return IPAddress.TryParse(ipAddress, out unused)
			  &&
			  (
				  unused.AddressFamily != System.Net.Sockets.AddressFamily.InterNetwork
				  ||
				  ipAddress.Count(c => c == '.') == 3
			  );
		}

		public string LocalIPAddress()
		{
			IPHostEntry host;
			string localIP = "";
			host = Dns.GetHostEntry(Dns.GetHostName());

			foreach (IPAddress ip in host.AddressList)
			{
				if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
				{
					localIP = ip.ToString();
					break;
				}
			}
			return localIP;
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			CheckForIllegalCrossThreadCalls = false;
			tbSourceIP.Text = LocalIPAddress();
			IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
			if (allDevices.Count == 0)
			{
				MessageBox.Show("Winpcap is missing or not installed. Please fix this!");
				Application.Exit();
			}
			for (int i = 0; i != allDevices.Count(); ++i)
			{
				cbAdapter.Items.Add(allDevices[i].Description);
			}
		}

		private void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				// set interface
				IList<LivePacketDevice> allDevices = LivePacketDevice.AllLocalMachine;
				PacketDevice selectedDevice = allDevices[cbAdapter.SelectedIndex];
				PacketCommunicator communicator = selectedDevice.Open(100, PacketDeviceOpenAttributes.Promiscuous, 1000);

				int numofpax = Convert.ToInt32(tbNumOfPackets.Text);
				string attackip = tbTarget.Text;
				string sourceip = tbSourceIP.Text;
				string payload = txtData.Text;
				int sourceport = Convert.ToInt32(tbSourcePort.Text);
				int destport = Convert.ToInt32(tbDestPort.Text);

				// loop here for packet sending

				for (int count = 0; count < numofpax; count++)
				{
					// call buildtcppacket here
					bool SYN, ACK, FIN, URG, RST, PSH, ENC, CWR, NS, NONE = false;
					if (cbSyn.Checked == true)
					{
						SYN = true;
					}
					if (cbAck.Checked == true)
					{
						ACK = true;
					}
					if (cbFin.Checked == true)
					{
						FIN = true;
					}
					if (cbRst.Checked == true)
					{
						RST = true;
					}
					if (cbUrg.Checked == true)
					{
						URG = true;
					}

					if (cbPsh.Checked == true)
					{
						PSH = true;
					}
					if (cbEnc.Checked == true)
					{
						ENC = true;
					}
					if (cbCwr.Checked == true)
					{
						CWR = true;
					}
					if (cbNs.Checked == true)
					{
						NS = true;
					}
					if (cbNone.Checked == true)
					{
						NONE = true;
					}
					//communicator.SendPacket(BuildTcpPacket(sourceip, attackip, sourceport, destport, payload, false, false, false, false, URG, false, false, false, false, false));

				}
			}
			catch (Exception ex)
			{
				// Exception case /*
				MessageBox.Show("An error as occurred:\n\nError in " + ex.Source + "\n\n" + ex.Message + "\n\n" + ex.StackTrace);
				// Exception case */
			}
		}

		private Packet BuildTcpPacket(string SourceIP, string DestIP, int sourceport, int destport,
			string payload, bool syn, bool ack, bool fin, bool rst, bool urg, bool psh, bool cwr, bool enc, bool ns, bool none)
		{
			EthernetLayer ethernetLayer = new EthernetLayer
			{
				Source = new MacAddress(tbSourceMac.Text),
				Destination = new MacAddress(tbDestMac.Text),
				EtherType = EthernetType.None, // Will be filled automatically.
			};

			IpV4Layer ipV4Layer = new IpV4Layer
			{
				Source = new IpV4Address(SourceIP),
				CurrentDestination = new IpV4Address(DestIP),
				Fragmentation = IpV4Fragmentation.None,
				HeaderChecksum = null, // Will be filled automatically.
				Identification = (ushort)Convert.ToInt16(tbIdNo.Text),
				Options = IpV4Options.None,
				Protocol = null, // Will be filled automatically.
				Ttl = (byte)Convert.ToInt16(tbTimeToLive.Text),
				TypeOfService = 0,
			};

			// flag fun here later
			TcpLayer tcpLayer = new TcpLayer();
			tcpLayer.SourcePort = (ushort)sourceport;
			tcpLayer.DestinationPort = (ushort)destport;
			tcpLayer.Checksum = null;// Will be filled automatically.
			tcpLayer.SequenceNumber = Convert.ToUInt16(tbSeqNo.Text);
			tcpLayer.AcknowledgmentNumber = (ushort)Convert.ToUInt16(tbAckNo.Text);
			if (syn)
				tcpLayer.ControlBits = TcpControlBits.Synchronize;
			if (ack)
				tcpLayer.ControlBits = TcpControlBits.Acknowledgment;
			if (fin)
				tcpLayer.ControlBits = TcpControlBits.Fin;
			if (rst)
				tcpLayer.ControlBits = TcpControlBits.Reset;
			if (urg)
				tcpLayer.ControlBits = TcpControlBits.Urgent;
			if (psh)
				tcpLayer.ControlBits = TcpControlBits.Push;
			if (cwr)
				tcpLayer.ControlBits = TcpControlBits.CongestionWindowReduced;
			if (enc)
				tcpLayer.ControlBits = TcpControlBits.ExplicitCongestionNotificationEcho;
			if (ns)
				tcpLayer.ControlBits = TcpControlBits.NonceSum; // not a flag, rather a tcp header bit set
			if (none)
				tcpLayer.ControlBits = TcpControlBits.None;

			tcpLayer.Window = (ushort)Convert.ToUInt16(tbWinLen.Text);
			tcpLayer.UrgentPointer = 0;
			tcpLayer.Options = TcpOptions.None;

			PayloadLayer payloadLayer = new PayloadLayer
			{
				Data = new Datagram(Encoding.ASCII.GetBytes(payload)),
			};

			PacketBuilder builder = new PacketBuilder(ethernetLayer, ipV4Layer, tcpLayer, payloadLayer);

			return builder.Build(DateTime.Now);
		}

		private void cbAck_CheckedChanged(object sender, EventArgs e)
		{
			if (cbAck.Checked == true)
			{
				tbAckNo.Enabled = true;
			}
			else
			{
				tbAckNo.Text = "0";
				tbAckNo.Enabled = false;
			}
		}

		private void btnCancel_Click_1(object sender, EventArgs e)
		{

		}

		private void btnOk_Click(object sender, EventArgs e)
		{

		}
	}
}