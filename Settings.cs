using PcapDotNet.Core;

namespace LOIC {
	
	
	// This class allows you to handle specific events on the settings class:
	//  The SettingChanging event is raised before a setting's value is changed.
	//  The PropertyChanged event is raised after a setting's value is changed.
	//  The SettingsLoaded event is raised after the setting values are loaded.
	//  The SettingsSaving event is raised before the setting values are saved.
	internal sealed class Settings {
		
		static Settings() {
			// // To add event handlers for saving and changing settings, uncomment the lines below:
			//
			// this.SettingChanging += this.SettingChangingEventHandler;
			//
			// this.SettingsSaving += this.SettingsSavingEventHandler;
			//
		}

		// flags
		internal static bool SYN { get; set; }
		internal static bool ACK { get; set; }
		internal static bool FIN { get; set; }
		internal static bool URG { get; set; }
		internal static bool RST { get; set; }
		internal static bool PSH { get; set; }
		internal static bool CWR { get; set; }
		internal static bool ENC { get; set; }
		internal static bool NS { get; set; }
		internal static bool NONE { get; set; }
		
		// target 
		public static string TargetHost, TargetIp, Payload, RelativePath;
		public static int TargetPort, NumThreads, Delay, Timeout;
		public static bool IntShowStats;
		
		public static PacketDevice SelectedDevice;
		public static AttackTypes AttackType;

	}

	public enum AttackTypes
	{
		TcpFlood,
		UdpFlood,
		HttpFlood
	}
}
