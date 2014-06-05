namespace LOIC
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label2 = new System.Windows.Forms.Label();
			this.cmdTargetIP = new System.Windows.Forms.Button();
			this.txtTargetIP = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.cmdTargetURL = new System.Windows.Forms.Button();
			this.txtTargetURL = new System.Windows.Forms.TextBox();
			this.txtPort = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtTarget = new System.Windows.Forms.TextBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.cbRandomSourceIpAndPort = new System.Windows.Forms.CheckBox();
			this.txtSourcePort = new System.Windows.Forms.TextBox();
			this.label30 = new System.Windows.Forms.Label();
			this.txtSourceIP = new System.Windows.Forms.TextBox();
			this.label29 = new System.Windows.Forms.Label();
			this.chkAllowGzip = new System.Windows.Forms.CheckBox();
			this.label18 = new System.Windows.Forms.Label();
			this.chkAllowRandom = new System.Windows.Forms.CheckBox();
			this.label17 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			this.chkWaitReply = new System.Windows.Forms.CheckBox();
			this.txtData = new System.Windows.Forms.TextBox();
			this.txtSubsite = new System.Windows.Forms.TextBox();
			this.txtTimeout = new System.Windows.Forms.TextBox();
			this.txtThreads = new System.Windows.Forms.TextBox();
			this.cbMethod = new System.Windows.Forms.ComboBox();
			this.tbSpeed = new System.Windows.Forms.TrackBar();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.btnAttack = new System.Windows.Forms.Button();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.label19 = new System.Windows.Forms.Label();
			this.lbFailed = new System.Windows.Forms.Label();
			this.lbRequested = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.label23 = new System.Windows.Forms.Label();
			this.lbDownloaded = new System.Windows.Forms.Label();
			this.lbDownloading = new System.Windows.Forms.Label();
			this.lbRequesting = new System.Windows.Forms.Label();
			this.lbConnecting = new System.Windows.Forms.Label();
			this.lbIdle = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.TTip = new System.Windows.Forms.ToolTip(this.components);
			this.label24 = new System.Windows.Forms.Label();
			this.enableHive = new System.Windows.Forms.RadioButton();
			this.tShowStats = new System.Windows.Forms.Timer(this.components);
			this.disableHive = new System.Windows.Forms.RadioButton();
			this.label25 = new System.Windows.Forms.Label();
			this.txtIRCserver = new System.Windows.Forms.TextBox();
			this.txtIRCport = new System.Windows.Forms.TextBox();
			this.txtIRCchannel = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label26 = new System.Windows.Forms.Label();
			this.label27 = new System.Windows.Forms.Label();
			this.pBanner = new System.Windows.Forms.PictureBox();
			this.gbFlags = new System.Windows.Forms.GroupBox();
			this.txtDestMac = new System.Windows.Forms.TextBox();
			this.txtSourceMac = new System.Windows.Forms.TextBox();
			this.label21 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.txtIdNo = new System.Windows.Forms.TextBox();
			this.txtAckNo = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txtTimeToLive = new System.Windows.Forms.TextBox();
			this.txtSeqNo = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbNone = new System.Windows.Forms.CheckBox();
			this.cbNs = new System.Windows.Forms.CheckBox();
			this.cbCwr = new System.Windows.Forms.CheckBox();
			this.cbEnc = new System.Windows.Forms.CheckBox();
			this.cbPsh = new System.Windows.Forms.CheckBox();
			this.cbRst = new System.Windows.Forms.CheckBox();
			this.cbUrg = new System.Windows.Forms.CheckBox();
			this.cbFin = new System.Windows.Forms.CheckBox();
			this.cbAck = new System.Windows.Forms.CheckBox();
			this.cbSyn = new System.Windows.Forms.CheckBox();
			this.label31 = new System.Windows.Forms.Label();
			this.cbAdapter = new System.Windows.Forms.ComboBox();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).BeginInit();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pBanner)).BeginInit();
			this.gbFlags.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.cmdTargetIP);
			this.groupBox1.Controls.Add(this.txtTargetIP);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.cmdTargetURL);
			this.groupBox1.Controls.Add(this.txtTargetURL);
			this.groupBox1.Controls.Add(this.txtPort);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.ForeColor = System.Drawing.Color.LightBlue;
			this.groupBox1.Location = new System.Drawing.Point(212, 65);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(488, 75);
			this.groupBox1.TabIndex = 1;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "1. Select your target";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(3, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(30, 14);
			this.label2.TabIndex = 5;
			this.label2.Text = "IP";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdTargetIP
			// 
			this.cmdTargetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.cmdTargetIP.ForeColor = System.Drawing.Color.Azure;
			this.cmdTargetIP.Location = new System.Drawing.Point(410, 46);
			this.cmdTargetIP.Name = "cmdTargetIP";
			this.cmdTargetIP.Size = new System.Drawing.Size(71, 22);
			this.cmdTargetIP.TabIndex = 4;
			this.cmdTargetIP.Text = "Lock on";
			this.cmdTargetIP.UseVisualStyleBackColor = false;
			this.cmdTargetIP.Click += new System.EventHandler(this.cmdTargetIP_Click);
			// 
			// txtTargetIP
			// 
			this.txtTargetIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtTargetIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTargetIP.ForeColor = System.Drawing.Color.Azure;
			this.txtTargetIP.Location = new System.Drawing.Point(39, 48);
			this.txtTargetIP.Name = "txtTargetIP";
			this.txtTargetIP.Size = new System.Drawing.Size(250, 20);
			this.txtTargetIP.TabIndex = 3;
			this.txtTargetIP.Text = "192.168.0.100";
			this.TTip.SetToolTip(this.txtTargetIP, "If you know your target\'s IP, enter the IP here and click \"Lock on\"");
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(3, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(30, 14);
			this.label1.TabIndex = 2;
			this.label1.Text = "URL";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cmdTargetURL
			// 
			this.cmdTargetURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.cmdTargetURL.ForeColor = System.Drawing.Color.Azure;
			this.cmdTargetURL.Location = new System.Drawing.Point(410, 19);
			this.cmdTargetURL.Name = "cmdTargetURL";
			this.cmdTargetURL.Size = new System.Drawing.Size(71, 22);
			this.cmdTargetURL.TabIndex = 2;
			this.cmdTargetURL.Text = "Lock on";
			this.cmdTargetURL.UseVisualStyleBackColor = false;
			this.cmdTargetURL.Click += new System.EventHandler(this.cmdTargetURL_Click);
			// 
			// txtTargetURL
			// 
			this.txtTargetURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtTargetURL.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTargetURL.ForeColor = System.Drawing.Color.Azure;
			this.txtTargetURL.Location = new System.Drawing.Point(39, 20);
			this.txtTargetURL.Name = "txtTargetURL";
			this.txtTargetURL.Size = new System.Drawing.Size(365, 20);
			this.txtTargetURL.TabIndex = 1;
			this.TTip.SetToolTip(this.txtTargetURL, "If you don\'t know your target\'s IP, enter a URL here and click \"Lock on\"");
			// 
			// txtPort
			// 
			this.txtPort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtPort.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPort.ForeColor = System.Drawing.Color.Azure;
			this.txtPort.Location = new System.Drawing.Point(346, 48);
			this.txtPort.Name = "txtPort";
			this.txtPort.Size = new System.Drawing.Size(54, 20);
			this.txtPort.TabIndex = 4;
			this.txtPort.Text = "139";
			this.txtPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TTip.SetToolTip(this.txtPort, "What port to attack (regular websites use 80)");
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(305, 50);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 14);
			this.label6.TabIndex = 20;
			this.label6.Text = "Port";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.txtTarget);
			this.groupBox2.ForeColor = System.Drawing.Color.LightBlue;
			this.groupBox2.Location = new System.Drawing.Point(212, 144);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(758, 96);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Selected target";
			// 
			// txtTarget
			// 
			this.txtTarget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTarget.Font = new System.Drawing.Font("Arial", 42F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.txtTarget.ForeColor = System.Drawing.Color.Azure;
			this.txtTarget.Location = new System.Drawing.Point(6, 17);
			this.txtTarget.Name = "txtTarget";
			this.txtTarget.Size = new System.Drawing.Size(746, 72);
			this.txtTarget.TabIndex = 1;
			this.txtTarget.TabStop = false;
			this.txtTarget.Text = "N O N E !";
			this.txtTarget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TTip.SetToolTip(this.txtTarget, "The currently selected target");
			this.txtTarget.Enter += new System.EventHandler(this.txtTarget_Enter);
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.cbRandomSourceIpAndPort);
			this.groupBox3.Controls.Add(this.txtSourcePort);
			this.groupBox3.Controls.Add(this.label30);
			this.groupBox3.Controls.Add(this.txtSourceIP);
			this.groupBox3.Controls.Add(this.label29);
			this.groupBox3.Controls.Add(this.chkAllowGzip);
			this.groupBox3.Controls.Add(this.label18);
			this.groupBox3.Controls.Add(this.chkAllowRandom);
			this.groupBox3.Controls.Add(this.label17);
			this.groupBox3.Controls.Add(this.label9);
			this.groupBox3.Controls.Add(this.label7);
			this.groupBox3.Controls.Add(this.label4);
			this.groupBox3.Controls.Add(this.label20);
			this.groupBox3.Controls.Add(this.chkWaitReply);
			this.groupBox3.Controls.Add(this.txtData);
			this.groupBox3.Controls.Add(this.txtSubsite);
			this.groupBox3.Controls.Add(this.txtTimeout);
			this.groupBox3.Controls.Add(this.txtThreads);
			this.groupBox3.Controls.Add(this.cbMethod);
			this.groupBox3.Controls.Add(this.tbSpeed);
			this.groupBox3.ForeColor = System.Drawing.Color.LightBlue;
			this.groupBox3.Location = new System.Drawing.Point(212, 244);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(758, 181);
			this.groupBox3.TabIndex = 4;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "2. Attack options";
			// 
			// cbRandomSourceIpAndPort
			// 
			this.cbRandomSourceIpAndPort.Location = new System.Drawing.Point(253, 42);
			this.cbRandomSourceIpAndPort.Name = "cbRandomSourceIpAndPort";
			this.cbRandomSourceIpAndPort.Size = new System.Drawing.Size(72, 18);
			this.cbRandomSourceIpAndPort.TabIndex = 36;
			this.cbRandomSourceIpAndPort.Text = "Random";
			this.TTip.SetToolTip(this.cbRandomSourceIpAndPort, "Enable Gzip support for HTTP method");
			this.cbRandomSourceIpAndPort.CheckedChanged += new System.EventHandler(this.cbRandomSourceIpAndPort_CheckedChanged);
			// 
			// txtSourcePort
			// 
			this.txtSourcePort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtSourcePort.ForeColor = System.Drawing.Color.Azure;
			this.txtSourcePort.Location = new System.Drawing.Point(189, 42);
			this.txtSourcePort.Name = "txtSourcePort";
			this.txtSourcePort.Size = new System.Drawing.Size(52, 20);
			this.txtSourcePort.TabIndex = 35;
			this.txtSourcePort.Text = "1337";
			// 
			// label30
			// 
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(186, 25);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(61, 14);
			this.label30.TabIndex = 34;
			this.label30.Text = "SourcePort";
			// 
			// txtSourceIP
			// 
			this.txtSourceIP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtSourceIP.ForeColor = System.Drawing.Color.Azure;
			this.txtSourceIP.Location = new System.Drawing.Point(9, 42);
			this.txtSourceIP.Multiline = true;
			this.txtSourceIP.Name = "txtSourceIP";
			this.txtSourceIP.Size = new System.Drawing.Size(165, 20);
			this.txtSourceIP.TabIndex = 32;
			this.txtSourceIP.Text = "192.168.0.111";
			// 
			// label29
			// 
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(59, 25);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(53, 14);
			this.label29.TabIndex = 30;
			this.label29.Text = "Source IP";
			// 
			// chkAllowGzip
			// 
			this.chkAllowGzip.Checked = true;
			this.chkAllowGzip.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkAllowGzip.Location = new System.Drawing.Point(640, 101);
			this.chkAllowGzip.Name = "chkAllowGzip";
			this.chkAllowGzip.Size = new System.Drawing.Size(114, 18);
			this.chkAllowGzip.TabIndex = 29;
			this.chkAllowGzip.Text = "Use Gzip (HTTP)";
			this.TTip.SetToolTip(this.chkAllowGzip, "Enable Gzip support for HTTP method");
			// 
			// label18
			// 
			this.label18.Location = new System.Drawing.Point(113, 65);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(124, 16);
			this.label18.TabIndex = 25;
			this.label18.Text = "TCP / UDP message";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chkAllowRandom
			// 
			this.chkAllowRandom.AutoSize = true;
			this.chkAllowRandom.Location = new System.Drawing.Point(62, 154);
			this.chkAllowRandom.Name = "chkAllowRandom";
			this.chkAllowRandom.Size = new System.Drawing.Size(255, 18);
			this.chkAllowRandom.TabIndex = 28;
			this.chkAllowRandom.Text = "Append random chars to the subsite / message";
			this.TTip.SetToolTip(this.chkAllowRandom, "Enable appending random chars to the subsite / message every request");
			this.chkAllowRandom.UseVisualStyleBackColor = true;
			// 
			// label17
			// 
			this.label17.Location = new System.Drawing.Point(133, 110);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(89, 17);
			this.label17.TabIndex = 24;
			this.label17.Text = "HTTP Subsite";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(573, 106);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(50, 15);
			this.label9.TabIndex = 23;
			this.label9.Text = "Timeout";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(511, 106);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(56, 15);
			this.label7.TabIndex = 22;
			this.label7.Text = "Threads";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(433, 108);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 15);
			this.label4.TabIndex = 21;
			this.label4.Text = "Method";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label20
			// 
			this.label20.Location = new System.Drawing.Point(370, 52);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(374, 15);
			this.label20.TabIndex = 18;
			this.label20.Text = "<= faster     Speed     slower =>";
			this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// chkWaitReply
			// 
			this.chkWaitReply.AutoSize = true;
			this.chkWaitReply.Checked = true;
			this.chkWaitReply.CheckState = System.Windows.Forms.CheckState.Checked;
			this.chkWaitReply.Location = new System.Drawing.Point(640, 77);
			this.chkWaitReply.Name = "chkWaitReply";
			this.chkWaitReply.Size = new System.Drawing.Size(91, 18);
			this.chkWaitReply.TabIndex = 7;
			this.chkWaitReply.Text = "Wait for reply";
			this.TTip.SetToolTip(this.chkWaitReply, "Don\'t disconnect before the server\'s started to answer");
			this.chkWaitReply.UseVisualStyleBackColor = true;
			// 
			// txtData
			// 
			this.txtData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtData.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtData.ForeColor = System.Drawing.Color.Azure;
			this.txtData.Location = new System.Drawing.Point(8, 83);
			this.txtData.Name = "txtData";
			this.txtData.Size = new System.Drawing.Size(333, 20);
			this.txtData.TabIndex = 3;
			this.txtData.Text = "U dun goofed";
			this.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TTip.SetToolTip(this.txtData, "The data to send in TCP/UDP mode");
			// 
			// txtSubsite
			// 
			this.txtSubsite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtSubsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtSubsite.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtSubsite.ForeColor = System.Drawing.Color.Azure;
			this.txtSubsite.Location = new System.Drawing.Point(8, 129);
			this.txtSubsite.Name = "txtSubsite";
			this.txtSubsite.Size = new System.Drawing.Size(333, 20);
			this.txtSubsite.TabIndex = 2;
			this.txtSubsite.Text = "/";
			this.txtSubsite.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TTip.SetToolTip(this.txtSubsite, "What subsite to target (when using HTTP as type)");
			// 
			// txtTimeout
			// 
			this.txtTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtTimeout.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtTimeout.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTimeout.ForeColor = System.Drawing.Color.Azure;
			this.txtTimeout.Location = new System.Drawing.Point(573, 83);
			this.txtTimeout.Name = "txtTimeout";
			this.txtTimeout.Size = new System.Drawing.Size(50, 20);
			this.txtTimeout.TabIndex = 1;
			this.txtTimeout.Text = "9001";
			this.txtTimeout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TTip.SetToolTip(this.txtTimeout, "Max time to wait for a response");
			// 
			// txtThreads
			// 
			this.txtThreads.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtThreads.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtThreads.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtThreads.ForeColor = System.Drawing.Color.Azure;
			this.txtThreads.Location = new System.Drawing.Point(511, 83);
			this.txtThreads.Name = "txtThreads";
			this.txtThreads.Size = new System.Drawing.Size(56, 20);
			this.txtThreads.TabIndex = 6;
			this.txtThreads.Text = "10";
			this.txtThreads.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.TTip.SetToolTip(this.txtThreads, "How many users LOIC should emulate");
			// 
			// cbMethod
			// 
			this.cbMethod.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.cbMethod.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
			this.cbMethod.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbMethod.ForeColor = System.Drawing.Color.Azure;
			this.cbMethod.FormattingEnabled = true;
			this.cbMethod.Items.AddRange(new object[] {
            "TCP",
            "UDP",
            "HTTP"});
			this.cbMethod.Location = new System.Drawing.Point(430, 83);
			this.cbMethod.Name = "cbMethod";
			this.cbMethod.Size = new System.Drawing.Size(75, 22);
			this.cbMethod.TabIndex = 5;
			this.cbMethod.Text = "TCP";
			this.TTip.SetToolTip(this.cbMethod, "What type of attack to launch");
			// 
			// tbSpeed
			// 
			this.tbSpeed.Location = new System.Drawing.Point(410, 26);
			this.tbSpeed.Maximum = 20;
			this.tbSpeed.Name = "tbSpeed";
			this.tbSpeed.Size = new System.Drawing.Size(334, 45);
			this.tbSpeed.TabIndex = 8;
			this.TTip.SetToolTip(this.tbSpeed, "Use this to increase or reduce attack speed");
			this.tbSpeed.ValueChanged += new System.EventHandler(this.tbSpeed_ValueChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.btnAttack);
			this.groupBox4.ForeColor = System.Drawing.Color.LightBlue;
			this.groupBox4.Location = new System.Drawing.Point(712, 65);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(258, 75);
			this.groupBox4.TabIndex = 2;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "3. Ready?";
			// 
			// btnAttack
			// 
			this.btnAttack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(64)))), ((int)(((byte)(96)))));
			this.btnAttack.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAttack.ForeColor = System.Drawing.Color.Azure;
			this.btnAttack.Location = new System.Drawing.Point(6, 19);
			this.btnAttack.Name = "btnAttack";
			this.btnAttack.Size = new System.Drawing.Size(246, 50);
			this.btnAttack.TabIndex = 1;
			this.btnAttack.Text = "IMMA CHARGIN MAH LAZER";
			this.TTip.SetToolTip(this.btnAttack, "I sincerely hope you can guess what this button does.");
			this.btnAttack.UseVisualStyleBackColor = false;
			this.btnAttack.Click += new System.EventHandler(this.cmdAttack_Click);
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.label19);
			this.groupBox5.Controls.Add(this.lbFailed);
			this.groupBox5.Controls.Add(this.lbRequested);
			this.groupBox5.Controls.Add(this.label22);
			this.groupBox5.Controls.Add(this.label23);
			this.groupBox5.Controls.Add(this.lbDownloaded);
			this.groupBox5.Controls.Add(this.lbDownloading);
			this.groupBox5.Controls.Add(this.lbRequesting);
			this.groupBox5.Controls.Add(this.lbConnecting);
			this.groupBox5.Controls.Add(this.lbIdle);
			this.groupBox5.Controls.Add(this.label12);
			this.groupBox5.Controls.Add(this.label13);
			this.groupBox5.Controls.Add(this.label14);
			this.groupBox5.Controls.Add(this.label15);
			this.groupBox5.Controls.Add(this.label16);
			this.groupBox5.ForeColor = System.Drawing.Color.LightBlue;
			this.groupBox5.Location = new System.Drawing.Point(212, 534);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(758, 68);
			this.groupBox5.TabIndex = 5;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Attack status";
			// 
			// label19
			// 
			this.label19.BackColor = System.Drawing.Color.Azure;
			this.label19.Location = new System.Drawing.Point(6, 40);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(746, 1);
			this.label19.TabIndex = 25;
			this.label19.Text = "Idle";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbFailed
			// 
			this.lbFailed.Location = new System.Drawing.Point(648, 41);
			this.lbFailed.Name = "lbFailed";
			this.lbFailed.Size = new System.Drawing.Size(101, 24);
			this.lbFailed.TabIndex = 24;
			this.lbFailed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TTip.SetToolTip(this.lbFailed, "How many times (in total) the webserver didn\'t respond. High number = server down" +
        ".");
			// 
			// lbRequested
			// 
			this.lbRequested.Location = new System.Drawing.Point(541, 41);
			this.lbRequested.Name = "lbRequested";
			this.lbRequested.Size = new System.Drawing.Size(101, 24);
			this.lbRequested.TabIndex = 23;
			this.lbRequested.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TTip.SetToolTip(this.lbRequested, "How many times (in total) a download has been requested");
			// 
			// label22
			// 
			this.label22.Location = new System.Drawing.Point(648, 16);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(101, 24);
			this.label22.TabIndex = 22;
			this.label22.Text = "Failed";
			this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label23
			// 
			this.label23.Location = new System.Drawing.Point(541, 16);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(101, 24);
			this.label23.TabIndex = 21;
			this.label23.Text = "Requested";
			this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lbDownloaded
			// 
			this.lbDownloaded.Location = new System.Drawing.Point(434, 41);
			this.lbDownloaded.Name = "lbDownloaded";
			this.lbDownloaded.Size = new System.Drawing.Size(101, 24);
			this.lbDownloaded.TabIndex = 20;
			this.lbDownloaded.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TTip.SetToolTip(this.lbDownloaded, "How many times (in total) that a download has been initiated");
			// 
			// lbDownloading
			// 
			this.lbDownloading.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
			this.lbDownloading.Location = new System.Drawing.Point(327, 41);
			this.lbDownloading.Name = "lbDownloading";
			this.lbDownloading.Size = new System.Drawing.Size(101, 24);
			this.lbDownloading.TabIndex = 19;
			this.lbDownloading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TTip.SetToolTip(this.lbDownloading, "How many threads that are downloading information from the server");
			// 
			// lbRequesting
			// 
			this.lbRequesting.Location = new System.Drawing.Point(220, 41);
			this.lbRequesting.Name = "lbRequesting";
			this.lbRequesting.Size = new System.Drawing.Size(101, 24);
			this.lbRequesting.TabIndex = 18;
			this.lbRequesting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TTip.SetToolTip(this.lbRequesting, "How many threads that are requesting information from the server");
			// 
			// lbConnecting
			// 
			this.lbConnecting.Location = new System.Drawing.Point(113, 41);
			this.lbConnecting.Name = "lbConnecting";
			this.lbConnecting.Size = new System.Drawing.Size(101, 24);
			this.lbConnecting.TabIndex = 17;
			this.lbConnecting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TTip.SetToolTip(this.lbConnecting, "How many threads that are trying to connect");
			// 
			// lbIdle
			// 
			this.lbIdle.Location = new System.Drawing.Point(6, 41);
			this.lbIdle.Name = "lbIdle";
			this.lbIdle.Size = new System.Drawing.Size(101, 24);
			this.lbIdle.TabIndex = 16;
			this.lbIdle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.TTip.SetToolTip(this.lbIdle, "How many threads that are without work. Should be 0");
			// 
			// label12
			// 
			this.label12.Location = new System.Drawing.Point(434, 16);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(101, 24);
			this.label12.TabIndex = 15;
			this.label12.Text = "Downloaded";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label13
			// 
			this.label13.Location = new System.Drawing.Point(327, 16);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(101, 24);
			this.label13.TabIndex = 14;
			this.label13.Text = "Downloading";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label14
			// 
			this.label14.Location = new System.Drawing.Point(220, 16);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(101, 24);
			this.label14.TabIndex = 13;
			this.label14.Text = "Requesting";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label15
			// 
			this.label15.Location = new System.Drawing.Point(113, 16);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(101, 24);
			this.label15.TabIndex = 12;
			this.label15.Text = "Connecting";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label16
			// 
			this.label16.Location = new System.Drawing.Point(6, 16);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(101, 24);
			this.label16.TabIndex = 11;
			this.label16.Text = "Idle";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(22, 452);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(165, 14);
			this.label24.TabIndex = 14;
			this.label24.Text = "github.com/NewEraCracker/LOIC";
			this.TTip.SetToolTip(this.label24, "Go to official page");
			this.label24.Click += new System.EventHandler(this.label24_Click);
			// 
			// enableHive
			// 
			this.enableHive.AutoSize = true;
			this.enableHive.Location = new System.Drawing.Point(377, 15);
			this.enableHive.Name = "enableHive";
			this.enableHive.Size = new System.Drawing.Size(124, 18);
			this.enableHive.TabIndex = 16;
			this.enableHive.Text = "IRC Mode (HiveMind)";
			this.TTip.SetToolTip(this.enableHive, "Fill the IRC options if you wish to use this mode");
			this.enableHive.UseVisualStyleBackColor = true;
			this.enableHive.CheckedChanged += new System.EventHandler(this.enableHive_CheckedChanged);
			// 
			// tShowStats
			// 
			this.tShowStats.Interval = 10;
			this.tShowStats.Tick += new System.EventHandler(this.tShowStats_Tick);
			// 
			// disableHive
			// 
			this.disableHive.AutoSize = true;
			this.disableHive.Checked = true;
			this.disableHive.Location = new System.Drawing.Point(212, 15);
			this.disableHive.Name = "disableHive";
			this.disableHive.Size = new System.Drawing.Size(163, 18);
			this.disableHive.TabIndex = 15;
			this.disableHive.TabStop = true;
			this.disableHive.Text = "Manual Mode (Do it yourself)";
			this.disableHive.UseVisualStyleBackColor = true;
			this.disableHive.CheckedChanged += new System.EventHandler(this.disableHive_CheckedChanged);
			// 
			// label25
			// 
			this.label25.Location = new System.Drawing.Point(760, 17);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(210, 16);
			this.label25.TabIndex = 17;
			this.label25.Text = "Disconnected.";
			// 
			// txtIRCserver
			// 
			this.txtIRCserver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtIRCserver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIRCserver.ForeColor = System.Drawing.Color.Azure;
			this.txtIRCserver.Location = new System.Drawing.Point(505, 15);
			this.txtIRCserver.Name = "txtIRCserver";
			this.txtIRCserver.Size = new System.Drawing.Size(107, 20);
			this.txtIRCserver.TabIndex = 18;
			// 
			// txtIRCport
			// 
			this.txtIRCport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtIRCport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIRCport.ForeColor = System.Drawing.Color.Azure;
			this.txtIRCport.Location = new System.Drawing.Point(618, 15);
			this.txtIRCport.Name = "txtIRCport";
			this.txtIRCport.Size = new System.Drawing.Size(53, 20);
			this.txtIRCport.TabIndex = 19;
			this.txtIRCport.Text = "6667";
			// 
			// txtIRCchannel
			// 
			this.txtIRCchannel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtIRCchannel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtIRCchannel.ForeColor = System.Drawing.Color.Azure;
			this.txtIRCchannel.Location = new System.Drawing.Point(677, 15);
			this.txtIRCchannel.Name = "txtIRCchannel";
			this.txtIRCchannel.Size = new System.Drawing.Size(77, 20);
			this.txtIRCchannel.TabIndex = 20;
			this.txtIRCchannel.Text = "#loic";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(502, 1);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(58, 14);
			this.label8.TabIndex = 21;
			this.label8.Text = "IRC server";
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(615, 1);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(26, 14);
			this.label26.TabIndex = 22;
			this.label26.Text = "Port";
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(674, 1);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(46, 14);
			this.label27.TabIndex = 23;
			this.label27.Text = "Channel";
			// 
			// pBanner
			// 
			this.pBanner.Image = global::LOIC.Properties.Resources.LOIC;
			this.pBanner.Location = new System.Drawing.Point(12, 12);
			this.pBanner.Name = "pBanner";
			this.pBanner.Size = new System.Drawing.Size(184, 462);
			this.pBanner.TabIndex = 12;
			this.pBanner.TabStop = false;
			// 
			// gbFlags
			// 
			this.gbFlags.Controls.Add(this.txtDestMac);
			this.gbFlags.Controls.Add(this.txtSourceMac);
			this.gbFlags.Controls.Add(this.label21);
			this.gbFlags.Controls.Add(this.label28);
			this.gbFlags.Controls.Add(this.txtIdNo);
			this.gbFlags.Controls.Add(this.txtAckNo);
			this.gbFlags.Controls.Add(this.label10);
			this.gbFlags.Controls.Add(this.label11);
			this.gbFlags.Controls.Add(this.txtTimeToLive);
			this.gbFlags.Controls.Add(this.txtSeqNo);
			this.gbFlags.Controls.Add(this.label3);
			this.gbFlags.Controls.Add(this.label5);
			this.gbFlags.Controls.Add(this.cbNone);
			this.gbFlags.Controls.Add(this.cbNs);
			this.gbFlags.Controls.Add(this.cbCwr);
			this.gbFlags.Controls.Add(this.cbEnc);
			this.gbFlags.Controls.Add(this.cbPsh);
			this.gbFlags.Controls.Add(this.cbRst);
			this.gbFlags.Controls.Add(this.cbUrg);
			this.gbFlags.Controls.Add(this.cbFin);
			this.gbFlags.Controls.Add(this.cbAck);
			this.gbFlags.Controls.Add(this.cbSyn);
			this.gbFlags.Location = new System.Drawing.Point(212, 427);
			this.gbFlags.Name = "gbFlags";
			this.gbFlags.Size = new System.Drawing.Size(758, 101);
			this.gbFlags.TabIndex = 24;
			this.gbFlags.TabStop = false;
			this.gbFlags.Text = "3.Flags";
			// 
			// txtDestMac
			// 
			this.txtDestMac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtDestMac.ForeColor = System.Drawing.Color.Azure;
			this.txtDestMac.Location = new System.Drawing.Point(580, 75);
			this.txtDestMac.Name = "txtDestMac";
			this.txtDestMac.Size = new System.Drawing.Size(161, 20);
			this.txtDestMac.TabIndex = 20;
			this.txtDestMac.Text = "FF:FF:FF:FF:FF:FF";
			// 
			// txtSourceMac
			// 
			this.txtSourceMac.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtSourceMac.ForeColor = System.Drawing.Color.Azure;
			this.txtSourceMac.Location = new System.Drawing.Point(580, 32);
			this.txtSourceMac.Name = "txtSourceMac";
			this.txtSourceMac.Size = new System.Drawing.Size(158, 20);
			this.txtSourceMac.TabIndex = 21;
			this.txtSourceMac.Text = "B8:AC:6F:3C:9C:93";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(580, 59);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(119, 14);
			this.label21.TabIndex = 18;
			this.label21.Text = "Dest HW MAC Address";
			// 
			// label28
			// 
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(580, 16);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(132, 14);
			this.label28.TabIndex = 19;
			this.label28.Text = "Source HW MAC Address";
			// 
			// txtIdNo
			// 
			this.txtIdNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtIdNo.ForeColor = System.Drawing.Color.Azure;
			this.txtIdNo.Location = new System.Drawing.Point(271, 68);
			this.txtIdNo.Name = "txtIdNo";
			this.txtIdNo.Size = new System.Drawing.Size(74, 20);
			this.txtIdNo.TabIndex = 16;
			this.txtIdNo.Text = "100";
			// 
			// txtAckNo
			// 
			this.txtAckNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtAckNo.Enabled = false;
			this.txtAckNo.ForeColor = System.Drawing.Color.Azure;
			this.txtAckNo.Location = new System.Drawing.Point(189, 68);
			this.txtAckNo.Name = "txtAckNo";
			this.txtAckNo.Size = new System.Drawing.Size(74, 20);
			this.txtAckNo.TabIndex = 17;
			this.txtAckNo.Text = "0";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(268, 50);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(56, 14);
			this.label10.TabIndex = 14;
			this.label10.Text = "ID Number";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(186, 49);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(66, 14);
			this.label11.TabIndex = 15;
			this.label11.Text = "Ack Number";
			// 
			// txtTimeToLive
			// 
			this.txtTimeToLive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtTimeToLive.ForeColor = System.Drawing.Color.Azure;
			this.txtTimeToLive.Location = new System.Drawing.Point(100, 68);
			this.txtTimeToLive.Name = "txtTimeToLive";
			this.txtTimeToLive.Size = new System.Drawing.Size(80, 20);
			this.txtTimeToLive.TabIndex = 12;
			this.txtTimeToLive.Text = "100";
			// 
			// txtSeqNo
			// 
			this.txtSeqNo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.txtSeqNo.ForeColor = System.Drawing.Color.Azure;
			this.txtSeqNo.Location = new System.Drawing.Point(20, 68);
			this.txtSeqNo.Name = "txtSeqNo";
			this.txtSeqNo.Size = new System.Drawing.Size(74, 20);
			this.txtSeqNo.TabIndex = 13;
			this.txtSeqNo.Text = "124";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(98, 52);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(66, 14);
			this.label3.TabIndex = 10;
			this.label3.Text = "Time To Live";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(16, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(66, 14);
			this.label5.TabIndex = 11;
			this.label5.Text = "Seq Number";
			// 
			// cbNone
			// 
			this.cbNone.AutoSize = true;
			this.cbNone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbNone.Location = new System.Drawing.Point(506, 25);
			this.cbNone.Name = "cbNone";
			this.cbNone.Size = new System.Drawing.Size(57, 17);
			this.cbNone.TabIndex = 0;
			this.cbNone.Text = "NONE";
			this.cbNone.UseVisualStyleBackColor = true;
			// 
			// cbNs
			// 
			this.cbNs.AutoSize = true;
			this.cbNs.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbNs.Location = new System.Drawing.Point(232, 26);
			this.cbNs.Name = "cbNs";
			this.cbNs.Size = new System.Drawing.Size(41, 17);
			this.cbNs.TabIndex = 0;
			this.cbNs.Text = "NS";
			this.cbNs.UseVisualStyleBackColor = true;
			// 
			// cbCwr
			// 
			this.cbCwr.AutoSize = true;
			this.cbCwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbCwr.Location = new System.Drawing.Point(390, 26);
			this.cbCwr.Name = "cbCwr";
			this.cbCwr.Size = new System.Drawing.Size(52, 17);
			this.cbCwr.TabIndex = 0;
			this.cbCwr.Text = "CWR";
			this.cbCwr.UseVisualStyleBackColor = true;
			// 
			// cbEnc
			// 
			this.cbEnc.AutoSize = true;
			this.cbEnc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbEnc.Location = new System.Drawing.Point(448, 25);
			this.cbEnc.Name = "cbEnc";
			this.cbEnc.Size = new System.Drawing.Size(48, 17);
			this.cbEnc.TabIndex = 0;
			this.cbEnc.Text = "ENC";
			this.cbEnc.UseVisualStyleBackColor = true;
			// 
			// cbPsh
			// 
			this.cbPsh.AutoSize = true;
			this.cbPsh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbPsh.Location = new System.Drawing.Point(178, 26);
			this.cbPsh.Name = "cbPsh";
			this.cbPsh.Size = new System.Drawing.Size(48, 17);
			this.cbPsh.TabIndex = 0;
			this.cbPsh.Text = "PSH";
			this.cbPsh.UseVisualStyleBackColor = true;
			// 
			// cbRst
			// 
			this.cbRst.AutoSize = true;
			this.cbRst.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbRst.Location = new System.Drawing.Point(123, 26);
			this.cbRst.Name = "cbRst";
			this.cbRst.Size = new System.Drawing.Size(48, 17);
			this.cbRst.TabIndex = 0;
			this.cbRst.Text = "RST";
			this.cbRst.UseVisualStyleBackColor = true;
			// 
			// cbUrg
			// 
			this.cbUrg.AutoSize = true;
			this.cbUrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbUrg.Location = new System.Drawing.Point(336, 26);
			this.cbUrg.Name = "cbUrg";
			this.cbUrg.Size = new System.Drawing.Size(50, 17);
			this.cbUrg.TabIndex = 0;
			this.cbUrg.Text = "URG";
			this.cbUrg.UseVisualStyleBackColor = true;
			// 
			// cbFin
			// 
			this.cbFin.AutoSize = true;
			this.cbFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFin.Location = new System.Drawing.Point(282, 26);
			this.cbFin.Name = "cbFin";
			this.cbFin.Size = new System.Drawing.Size(43, 17);
			this.cbFin.TabIndex = 0;
			this.cbFin.Text = "FIN";
			this.cbFin.UseVisualStyleBackColor = true;
			// 
			// cbAck
			// 
			this.cbAck.AutoSize = true;
			this.cbAck.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbAck.Location = new System.Drawing.Point(70, 26);
			this.cbAck.Name = "cbAck";
			this.cbAck.Size = new System.Drawing.Size(47, 17);
			this.cbAck.TabIndex = 0;
			this.cbAck.Text = "ACK";
			this.cbAck.UseVisualStyleBackColor = true;
			this.cbAck.CheckedChanged += new System.EventHandler(this.cbAck_CheckedChanged);
			// 
			// cbSyn
			// 
			this.cbSyn.AutoSize = true;
			this.cbSyn.Checked = true;
			this.cbSyn.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbSyn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSyn.Location = new System.Drawing.Point(16, 26);
			this.cbSyn.Name = "cbSyn";
			this.cbSyn.Size = new System.Drawing.Size(48, 17);
			this.cbSyn.TabIndex = 0;
			this.cbSyn.Text = "SYN";
			this.cbSyn.UseVisualStyleBackColor = true;
			// 
			// label31
			// 
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(218, 41);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(78, 14);
			this.label31.TabIndex = 26;
			this.label31.Text = "Select Adapter";
			// 
			// cbAdapter
			// 
			this.cbAdapter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(48)))), ((int)(((byte)(64)))));
			this.cbAdapter.FormattingEnabled = true;
			this.cbAdapter.Location = new System.Drawing.Point(315, 38);
			this.cbAdapter.Name = "cbAdapter";
			this.cbAdapter.Size = new System.Drawing.Size(654, 22);
			this.cbAdapter.TabIndex = 25;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
			this.ClientSize = new System.Drawing.Size(982, 614);
			this.Controls.Add(this.label31);
			this.Controls.Add(this.cbAdapter);
			this.Controls.Add(this.gbFlags);
			this.Controls.Add(this.label27);
			this.Controls.Add(this.label26);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.txtIRCchannel);
			this.Controls.Add(this.txtIRCport);
			this.Controls.Add(this.txtIRCserver);
			this.Controls.Add(this.label25);
			this.Controls.Add(this.enableHive);
			this.Controls.Add(this.disableHive);
			this.Controls.Add(this.label24);
			this.Controls.Add(this.pBanner);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ForeColor = System.Drawing.Color.LightBlue;
			this.MaximizeBox = false;
			this.Name = "frmMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmMain";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_Closing);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			this.groupBox3.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.tbSpeed)).EndInit();
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pBanner)).EndInit();
			this.gbFlags.ResumeLayout(false);
			this.gbFlags.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button cmdTargetURL;
		private System.Windows.Forms.TextBox txtTargetURL;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button cmdTargetIP;
		private System.Windows.Forms.TextBox txtTargetIP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.TextBox txtTarget;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.TextBox txtPort;
		private System.Windows.Forms.TextBox txtThreads;
		private System.Windows.Forms.ComboBox cbMethod;
		private System.Windows.Forms.TextBox txtTimeout;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.Button btnAttack;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label lbDownloaded;
		private System.Windows.Forms.Label lbDownloading;
		private System.Windows.Forms.Label lbRequesting;
		private System.Windows.Forms.Label lbConnecting;
		private System.Windows.Forms.Label lbIdle;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label lbFailed;
		private System.Windows.Forms.Label lbRequested;
		private System.Windows.Forms.TextBox txtSubsite;
		private System.Windows.Forms.ToolTip TTip;
		private System.Windows.Forms.TextBox txtData;
		private System.Windows.Forms.Timer tShowStats;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.CheckBox chkWaitReply;
		private System.Windows.Forms.TrackBar tbSpeed;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.PictureBox pBanner;
		private System.Windows.Forms.CheckBox chkAllowGzip;
		private System.Windows.Forms.CheckBox chkAllowRandom;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.RadioButton disableHive;
 		private System.Windows.Forms.RadioButton enableHive;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.TextBox txtIRCserver;
		private System.Windows.Forms.TextBox txtIRCport;
		private System.Windows.Forms.TextBox txtIRCchannel;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.GroupBox gbFlags;
		private System.Windows.Forms.CheckBox cbNone;
		private System.Windows.Forms.CheckBox cbNs;
		private System.Windows.Forms.CheckBox cbCwr;
		private System.Windows.Forms.CheckBox cbEnc;
		private System.Windows.Forms.CheckBox cbPsh;
		private System.Windows.Forms.CheckBox cbRst;
		private System.Windows.Forms.CheckBox cbUrg;
		private System.Windows.Forms.CheckBox cbFin;
		private System.Windows.Forms.CheckBox cbAck;
		private System.Windows.Forms.CheckBox cbSyn;
		private System.Windows.Forms.TextBox txtTimeToLive;
		private System.Windows.Forms.TextBox txtSeqNo;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txtIdNo;
		private System.Windows.Forms.TextBox txtAckNo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox txtDestMac;
		private System.Windows.Forms.TextBox txtSourceMac;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.TextBox txtSourcePort;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.TextBox txtSourceIP;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.CheckBox cbRandomSourceIpAndPort;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.ComboBox cbAdapter;
	}
}