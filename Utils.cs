using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace LOIC
{
	class Utils
	{

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

		public static string LocalIPAddress()
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

	}
}
