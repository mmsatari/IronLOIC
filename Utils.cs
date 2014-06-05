using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace LOIC
{
	class Utils
	{
		public static string RandomString()
		{
			StringBuilder builder = new StringBuilder();
			Random random = new Random();
			char ch;
			for (int i = 0; i < 6; i++)
			{
				ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
				builder.Append(ch);
			}
			return builder.ToString();
		}

		public static string RandomUserAgent()
		{
			Random random = new Random();

			String[] osversions = { "5.1", "6.0", "6.1" };
			String[] oslanguages = { "en-GB", "en-US", "es-ES", "pt-BR", "pt-PT", "sv-SE" };

			String version = osversions[random.Next(0, osversions.Length - 1)];
			String language = oslanguages[random.Next(0, oslanguages.Length - 1)];
			String useragent = String.Format("Mozilla/5.0 (Windows; U; Windows NT {0}; {1}; rv:1.9.2.17) Gecko/20110420 Firefox/3.6.17", version, language);

			return useragent;
		}

		public static bool IsValidIP(string ipAddress)
		{
			IPAddress unused;
			return IPAddress.TryParse(ipAddress, out unused)
			  &&
			  (
				  unused.AddressFamily != AddressFamily.InterNetwork
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
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					localIP = ip.ToString();
					break;
				}
			}
			return localIP;
		}
	}
}
