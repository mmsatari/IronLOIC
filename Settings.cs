using PcapDotNet.Core;

namespace LOIC {
	
	public struct Flags
	{
		public bool SYN;
		public bool ACK;
		public bool FIN;
		public bool URG;
		public bool RST;
		public bool PSH;
		public bool CWR;
		public bool ENC;
		public bool NS;
		public bool NONE;
	}
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
		public static Flags Flags = new Flags();
		
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
