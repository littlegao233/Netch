namespace Netch.Forms
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.PortGroupBox = new System.Windows.Forms.GroupBox();
            this.RedirectorLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RedirectorTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AllowDevicesCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.HTTPPortLabel = new MaterialSkin.Controls.MaterialLabel();
            this.HTTPPortTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.Socks5PortLabel = new MaterialSkin.Controls.MaterialLabel();
            this.Socks5PortTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TUNTAPGroupBox = new System.Windows.Forms.GroupBox();
            this.UseFakeDNSCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.ProxyDNSCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.UseCustomDNSCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.TUNTAPDNSLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TUNTAPDNSTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TUNTAPGatewayLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TUNTAPGatewayTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TUNTAPNetmaskLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TUNTAPNetmaskTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.TUNTAPAddressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TUNTAPAddressTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ControlButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.GlobalBypassIPsButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.BehaviorGroupBox = new System.Windows.Forms.GroupBox();
            this.BootShadowsocksFromDLLCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.AclAddr = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AclLabel = new MaterialSkin.Controls.MaterialLabel();
            this.DetectionInterval_Label = new MaterialSkin.Controls.MaterialLabel();
            this.DetectionInterval_TextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.EnableStartedTcping_CheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.DelayTestAfterStartup_Label = new MaterialSkin.Controls.MaterialLabel();
            this.STUN_ServerPortTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.STUNServerPortLabel = new MaterialSkin.Controls.MaterialLabel();
            this.STUNServerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RunAtStartup = new MaterialSkin.Controls.MaterialCheckBox();
            this.STUN_ServerTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.MinimizeWhenStartedCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.ProfileCount_Label = new MaterialSkin.Controls.MaterialLabel();
            this.ProfileCount_TextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.CheckUpdateWhenOpenedCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.StartWhenOpenedCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.StopWhenExitedCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.ExitWhenClosedCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PortGroupBox.SuspendLayout();
            this.TUNTAPGroupBox.SuspendLayout();
            this.BehaviorGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PortGroupBox
            // 
            this.PortGroupBox.Controls.Add(this.RedirectorLabel);
            this.PortGroupBox.Controls.Add(this.RedirectorTextBox);
            this.PortGroupBox.Controls.Add(this.AllowDevicesCheckBox);
            this.PortGroupBox.Controls.Add(this.HTTPPortLabel);
            this.PortGroupBox.Controls.Add(this.HTTPPortTextBox);
            this.PortGroupBox.Controls.Add(this.Socks5PortLabel);
            this.PortGroupBox.Controls.Add(this.Socks5PortTextBox);
            this.PortGroupBox.Location = new System.Drawing.Point(18, 18);
            this.PortGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.PortGroupBox.Name = "PortGroupBox";
            this.PortGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.PortGroupBox.Size = new System.Drawing.Size(630, 210);
            this.PortGroupBox.TabIndex = 0;
            this.PortGroupBox.TabStop = false;
            this.PortGroupBox.Text = "Local Port";
            // 
            // RedirectorLabel
            // 
            this.RedirectorLabel.AutoSize = true;
            this.RedirectorLabel.Depth = 0;
            this.RedirectorLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RedirectorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RedirectorLabel.Location = new System.Drawing.Point(14, 124);
            this.RedirectorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RedirectorLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RedirectorLabel.Name = "RedirectorLabel";
            this.RedirectorLabel.Size = new System.Drawing.Size(159, 27);
            this.RedirectorLabel.TabIndex = 6;
            this.RedirectorLabel.Text = "Redirector TCP";
            // 
            // RedirectorTextBox
            // 
            this.RedirectorTextBox.Location = new System.Drawing.Point(180, 120);
            this.RedirectorTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RedirectorTextBox.Name = "RedirectorTextBox";
            this.RedirectorTextBox.Size = new System.Drawing.Size(439, 31);
            this.RedirectorTextBox.TabIndex = 7;
            //this.RedirectorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AllowDevicesCheckBox
            // 
            this.AllowDevicesCheckBox.AutoSize = true;
            this.AllowDevicesCheckBox.Depth = 0;
            this.AllowDevicesCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.AllowDevicesCheckBox.Location = new System.Drawing.Point(180, 164);
            this.AllowDevicesCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.AllowDevicesCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.AllowDevicesCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.AllowDevicesCheckBox.Name = "AllowDevicesCheckBox";
            this.AllowDevicesCheckBox.Ripple = true;
            this.AllowDevicesCheckBox.Size = new System.Drawing.Size(317, 30);
            this.AllowDevicesCheckBox.TabIndex = 5;
            this.AllowDevicesCheckBox.Text = "Allow other Devices to connect";
            this.AllowDevicesCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AllowDevicesCheckBox.UseVisualStyleBackColor = true;
            // 
            // HTTPPortLabel
            // 
            this.HTTPPortLabel.AutoSize = true;
            this.HTTPPortLabel.Depth = 0;
            this.HTTPPortLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.HTTPPortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.HTTPPortLabel.Location = new System.Drawing.Point(14, 81);
            this.HTTPPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HTTPPortLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.HTTPPortLabel.Name = "HTTPPortLabel";
            this.HTTPPortLabel.Size = new System.Drawing.Size(68, 27);
            this.HTTPPortLabel.TabIndex = 3;
            this.HTTPPortLabel.Text = "HTTP";
            // 
            // HTTPPortTextBox
            // 
            this.HTTPPortTextBox.Location = new System.Drawing.Point(180, 76);
            this.HTTPPortTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HTTPPortTextBox.Name = "HTTPPortTextBox";
            this.HTTPPortTextBox.Size = new System.Drawing.Size(439, 31);
            this.HTTPPortTextBox.TabIndex = 4;
            //this.HTTPPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Socks5PortLabel
            // 
            this.Socks5PortLabel.AutoSize = true;
            this.Socks5PortLabel.Depth = 0;
            this.Socks5PortLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.Socks5PortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Socks5PortLabel.Location = new System.Drawing.Point(14, 38);
            this.Socks5PortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Socks5PortLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.Socks5PortLabel.Name = "Socks5PortLabel";
            this.Socks5PortLabel.Size = new System.Drawing.Size(84, 27);
            this.Socks5PortLabel.TabIndex = 0;
            this.Socks5PortLabel.Text = "Socks5";
            // 
            // Socks5PortTextBox
            // 
            this.Socks5PortTextBox.Location = new System.Drawing.Point(180, 33);
            this.Socks5PortTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Socks5PortTextBox.Name = "Socks5PortTextBox";
            this.Socks5PortTextBox.Size = new System.Drawing.Size(439, 31);
            this.Socks5PortTextBox.TabIndex = 1;
            //this.Socks5PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPGroupBox
            // 
            this.TUNTAPGroupBox.Controls.Add(this.UseFakeDNSCheckBox);
            this.TUNTAPGroupBox.Controls.Add(this.ProxyDNSCheckBox);
            this.TUNTAPGroupBox.Controls.Add(this.UseCustomDNSCheckBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPDNSLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPDNSTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPGatewayLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPGatewayTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPNetmaskLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPNetmaskTextBox);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPAddressLabel);
            this.TUNTAPGroupBox.Controls.Add(this.TUNTAPAddressTextBox);
            this.TUNTAPGroupBox.Location = new System.Drawing.Point(18, 237);
            this.TUNTAPGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.TUNTAPGroupBox.Name = "TUNTAPGroupBox";
            this.TUNTAPGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.TUNTAPGroupBox.Size = new System.Drawing.Size(630, 280);
            this.TUNTAPGroupBox.TabIndex = 3;
            this.TUNTAPGroupBox.TabStop = false;
            this.TUNTAPGroupBox.Text = "TUN/TAP";
            // 
            // UseFakeDNSCheckBox
            // 
            this.UseFakeDNSCheckBox.AutoSize = true;
            this.UseFakeDNSCheckBox.Depth = 0;
            this.UseFakeDNSCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.UseFakeDNSCheckBox.Location = new System.Drawing.Point(15, 240);
            this.UseFakeDNSCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UseFakeDNSCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UseFakeDNSCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.UseFakeDNSCheckBox.Name = "UseFakeDNSCheckBox";
            this.UseFakeDNSCheckBox.Ripple = true;
            this.UseFakeDNSCheckBox.Size = new System.Drawing.Size(162, 30);
            this.UseFakeDNSCheckBox.TabIndex = 11;
            this.UseFakeDNSCheckBox.Text = "Use Fake DNS";
            this.UseFakeDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProxyDNSCheckBox
            // 
            this.ProxyDNSCheckBox.AutoSize = true;
            this.ProxyDNSCheckBox.Depth = 0;
            this.ProxyDNSCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ProxyDNSCheckBox.Location = new System.Drawing.Point(392, 208);
            this.ProxyDNSCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProxyDNSCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ProxyDNSCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProxyDNSCheckBox.Name = "ProxyDNSCheckBox";
            this.ProxyDNSCheckBox.Ripple = true;
            this.ProxyDNSCheckBox.Size = new System.Drawing.Size(227, 30);
            this.ProxyDNSCheckBox.TabIndex = 10;
            this.ProxyDNSCheckBox.Text = "Proxy DNS in Mode 2";
            this.ProxyDNSCheckBox.UseVisualStyleBackColor = true;
            // 
            // UseCustomDNSCheckBox
            // 
            this.UseCustomDNSCheckBox.AutoSize = true;
            this.UseCustomDNSCheckBox.Depth = 0;
            this.UseCustomDNSCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.UseCustomDNSCheckBox.Location = new System.Drawing.Point(15, 208);
            this.UseCustomDNSCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UseCustomDNSCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UseCustomDNSCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.UseCustomDNSCheckBox.Name = "UseCustomDNSCheckBox";
            this.UseCustomDNSCheckBox.Ripple = true;
            this.UseCustomDNSCheckBox.Size = new System.Drawing.Size(190, 30);
            this.UseCustomDNSCheckBox.TabIndex = 9;
            this.UseCustomDNSCheckBox.Text = "Use Custom DNS";
            this.UseCustomDNSCheckBox.UseVisualStyleBackColor = true;
            this.UseCustomDNSCheckBox.CheckedChanged += new System.EventHandler(this.TUNTAPUseCustomDNSCheckBox_CheckedChanged);
            // 
            // TUNTAPDNSLabel
            // 
            this.TUNTAPDNSLabel.AutoSize = true;
            this.TUNTAPDNSLabel.Depth = 0;
            this.TUNTAPDNSLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.TUNTAPDNSLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TUNTAPDNSLabel.Location = new System.Drawing.Point(14, 168);
            this.TUNTAPDNSLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TUNTAPDNSLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TUNTAPDNSLabel.Name = "TUNTAPDNSLabel";
            this.TUNTAPDNSLabel.Size = new System.Drawing.Size(55, 27);
            this.TUNTAPDNSLabel.TabIndex = 7;
            this.TUNTAPDNSLabel.Text = "DNS";
            // 
            // TUNTAPDNSTextBox
            // 
            this.TUNTAPDNSTextBox.Location = new System.Drawing.Point(180, 165);
            this.TUNTAPDNSTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TUNTAPDNSTextBox.Name = "TUNTAPDNSTextBox";
            this.TUNTAPDNSTextBox.Size = new System.Drawing.Size(439, 31);
            this.TUNTAPDNSTextBox.TabIndex = 8;
            //this.TUNTAPDNSTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPGatewayLabel
            // 
            this.TUNTAPGatewayLabel.AutoSize = true;
            this.TUNTAPGatewayLabel.Depth = 0;
            this.TUNTAPGatewayLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.TUNTAPGatewayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TUNTAPGatewayLabel.Location = new System.Drawing.Point(14, 124);
            this.TUNTAPGatewayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TUNTAPGatewayLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TUNTAPGatewayLabel.Name = "TUNTAPGatewayLabel";
            this.TUNTAPGatewayLabel.Size = new System.Drawing.Size(97, 27);
            this.TUNTAPGatewayLabel.TabIndex = 5;
            this.TUNTAPGatewayLabel.Text = "Gateway";
            // 
            // TUNTAPGatewayTextBox
            // 
            this.TUNTAPGatewayTextBox.Location = new System.Drawing.Point(180, 120);
            this.TUNTAPGatewayTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TUNTAPGatewayTextBox.Name = "TUNTAPGatewayTextBox";
            this.TUNTAPGatewayTextBox.Size = new System.Drawing.Size(439, 31);
            this.TUNTAPGatewayTextBox.TabIndex = 6;
            //this.TUNTAPGatewayTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPNetmaskLabel
            // 
            this.TUNTAPNetmaskLabel.AutoSize = true;
            this.TUNTAPNetmaskLabel.Depth = 0;
            this.TUNTAPNetmaskLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.TUNTAPNetmaskLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TUNTAPNetmaskLabel.Location = new System.Drawing.Point(14, 81);
            this.TUNTAPNetmaskLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TUNTAPNetmaskLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TUNTAPNetmaskLabel.Name = "TUNTAPNetmaskLabel";
            this.TUNTAPNetmaskLabel.Size = new System.Drawing.Size(100, 27);
            this.TUNTAPNetmaskLabel.TabIndex = 3;
            this.TUNTAPNetmaskLabel.Text = "Netmask";
            // 
            // TUNTAPNetmaskTextBox
            // 
            this.TUNTAPNetmaskTextBox.Location = new System.Drawing.Point(180, 76);
            this.TUNTAPNetmaskTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TUNTAPNetmaskTextBox.Name = "TUNTAPNetmaskTextBox";
            this.TUNTAPNetmaskTextBox.Size = new System.Drawing.Size(439, 31);
            this.TUNTAPNetmaskTextBox.TabIndex = 4;
            //this.TUNTAPNetmaskTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TUNTAPAddressLabel
            // 
            this.TUNTAPAddressLabel.AutoSize = true;
            this.TUNTAPAddressLabel.Depth = 0;
            this.TUNTAPAddressLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.TUNTAPAddressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TUNTAPAddressLabel.Location = new System.Drawing.Point(14, 38);
            this.TUNTAPAddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TUNTAPAddressLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.TUNTAPAddressLabel.Name = "TUNTAPAddressLabel";
            this.TUNTAPAddressLabel.Size = new System.Drawing.Size(91, 27);
            this.TUNTAPAddressLabel.TabIndex = 1;
            this.TUNTAPAddressLabel.Text = "Address";
            // 
            // TUNTAPAddressTextBox
            // 
            this.TUNTAPAddressTextBox.Location = new System.Drawing.Point(180, 33);
            this.TUNTAPAddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.TUNTAPAddressTextBox.Name = "TUNTAPAddressTextBox";
            this.TUNTAPAddressTextBox.Size = new System.Drawing.Size(439, 31);
            this.TUNTAPAddressTextBox.TabIndex = 2;
            //this.TUNTAPAddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ControlButton
            // 
            this.ControlButton.AutoSize = true;
            this.ControlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlButton.Depth = 0;
            this.ControlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlButton.Location = new System.Drawing.Point(906, 9);
            this.ControlButton.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ControlButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Primary = false;
            this.ControlButton.Size = new System.Drawing.Size(389, 39);
            this.ControlButton.TabIndex = 11;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // GlobalBypassIPsButton
            // 
            this.GlobalBypassIPsButton.AutoSize = true;
            this.GlobalBypassIPsButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.GlobalBypassIPsButton.Depth = 0;
            this.GlobalBypassIPsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GlobalBypassIPsButton.Location = new System.Drawing.Point(6, 9);
            this.GlobalBypassIPsButton.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.GlobalBypassIPsButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.GlobalBypassIPsButton.Name = "GlobalBypassIPsButton";
            this.GlobalBypassIPsButton.Primary = false;
            this.GlobalBypassIPsButton.Size = new System.Drawing.Size(388, 39);
            this.GlobalBypassIPsButton.TabIndex = 10;
            this.GlobalBypassIPsButton.Text = "Global Bypass IPs";
            this.GlobalBypassIPsButton.UseVisualStyleBackColor = true;
            this.GlobalBypassIPsButton.Click += new System.EventHandler(this.GlobalBypassIPsButton_Click);
            // 
            // BehaviorGroupBox
            // 
            this.BehaviorGroupBox.Controls.Add(this.LanguageLabel);
            this.BehaviorGroupBox.Controls.Add(this.LanguageComboBox);
            this.BehaviorGroupBox.Controls.Add(this.BootShadowsocksFromDLLCheckBox);
            this.BehaviorGroupBox.Controls.Add(this.AclAddr);
            this.BehaviorGroupBox.Controls.Add(this.AclLabel);
            this.BehaviorGroupBox.Controls.Add(this.DetectionInterval_Label);
            this.BehaviorGroupBox.Controls.Add(this.DetectionInterval_TextBox);
            this.BehaviorGroupBox.Controls.Add(this.EnableStartedTcping_CheckBox);
            this.BehaviorGroupBox.Controls.Add(this.DelayTestAfterStartup_Label);
            this.BehaviorGroupBox.Controls.Add(this.STUN_ServerPortTextBox);
            this.BehaviorGroupBox.Controls.Add(this.STUNServerPortLabel);
            this.BehaviorGroupBox.Controls.Add(this.STUNServerLabel);
            this.BehaviorGroupBox.Controls.Add(this.RunAtStartup);
            this.BehaviorGroupBox.Controls.Add(this.STUN_ServerTextBox);
            this.BehaviorGroupBox.Controls.Add(this.MinimizeWhenStartedCheckBox);
            this.BehaviorGroupBox.Controls.Add(this.ProfileCount_Label);
            this.BehaviorGroupBox.Controls.Add(this.ProfileCount_TextBox);
            this.BehaviorGroupBox.Controls.Add(this.CheckUpdateWhenOpenedCheckBox);
            this.BehaviorGroupBox.Controls.Add(this.StartWhenOpenedCheckBox);
            this.BehaviorGroupBox.Controls.Add(this.StopWhenExitedCheckBox);
            this.BehaviorGroupBox.Controls.Add(this.ExitWhenClosedCheckBox);
            this.BehaviorGroupBox.Location = new System.Drawing.Point(657, 18);
            this.BehaviorGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.BehaviorGroupBox.Name = "BehaviorGroupBox";
            this.BehaviorGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.BehaviorGroupBox.Size = new System.Drawing.Size(662, 500);
            this.BehaviorGroupBox.TabIndex = 8;
            this.BehaviorGroupBox.TabStop = false;
            this.BehaviorGroupBox.Text = "Behavior";
            // 
            // LanguageLabel
            // 
            this.LanguageLabel.AutoSize = true;
            this.LanguageLabel.Location = new System.Drawing.Point(12, 305);
            this.LanguageLabel.Name = "LanguageLabel";
            this.LanguageLabel.Size = new System.Drawing.Size(65, 17);
            this.LanguageLabel.TabIndex = 23;
            this.LanguageLabel.Text = "Language";
            // 
            // LanguageComboBox
            // 
            this.LanguageComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LanguageComboBox.FormattingEnabled = true;
            this.LanguageComboBox.Location = new System.Drawing.Point(120, 302);
            this.LanguageComboBox.Name = "LanguageComboBox";
            this.LanguageComboBox.Size = new System.Drawing.Size(121, 25);
            this.LanguageComboBox.TabIndex = 22;
            // 
            // BootShadowsocksFromDLLCheckBox
            // 
            this.BootShadowsocksFromDLLCheckBox.AutoSize = true;
            this.BootShadowsocksFromDLLCheckBox.Depth = 0;
            this.BootShadowsocksFromDLLCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.BootShadowsocksFromDLLCheckBox.Location = new System.Drawing.Point(18, 153);
            this.BootShadowsocksFromDLLCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.BootShadowsocksFromDLLCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.BootShadowsocksFromDLLCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.BootShadowsocksFromDLLCheckBox.Name = "BootShadowsocksFromDLLCheckBox";
            this.BootShadowsocksFromDLLCheckBox.Ripple = true;
            this.BootShadowsocksFromDLLCheckBox.Size = new System.Drawing.Size(497, 30);
            this.BootShadowsocksFromDLLCheckBox.TabIndex = 21;
            this.BootShadowsocksFromDLLCheckBox.Text = "Start Shadowsocks from DLL (No support for ACL)";
            this.BootShadowsocksFromDLLCheckBox.UseVisualStyleBackColor = true;
            // 
            // AclAddr
            // 
            this.AclAddr.Location = new System.Drawing.Point(225, 453);
            this.AclAddr.Margin = new System.Windows.Forms.Padding(4);
            this.AclAddr.Name = "AclAddr";
            this.AclAddr.Size = new System.Drawing.Size(425, 31);
            this.AclAddr.TabIndex = 19;
            //this.AclAddr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AclLabel
            // 
            this.AclLabel.AutoSize = true;
            this.AclLabel.Depth = 0;
            this.AclLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.AclLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AclLabel.Location = new System.Drawing.Point(18, 458);
            this.AclLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AclLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.AclLabel.Name = "AclLabel";
            this.AclLabel.Size = new System.Drawing.Size(133, 27);
            this.AclLabel.TabIndex = 20;
            this.AclLabel.Text = "Custom ACL";
            // 
            // DetectionInterval_Label
            // 
            this.DetectionInterval_Label.AutoSize = true;
            this.DetectionInterval_Label.Depth = 0;
            this.DetectionInterval_Label.Font = new System.Drawing.Font("Roboto", 11F);
            this.DetectionInterval_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DetectionInterval_Label.Location = new System.Drawing.Point(320, 330);
            this.DetectionInterval_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DetectionInterval_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.DetectionInterval_Label.Name = "DetectionInterval_Label";
            this.DetectionInterval_Label.Size = new System.Drawing.Size(233, 27);
            this.DetectionInterval_Label.TabIndex = 18;
            this.DetectionInterval_Label.Text = "Detection interval(sec)";
            // 
            // DetectionInterval_TextBox
            // 
            this.DetectionInterval_TextBox.Location = new System.Drawing.Point(561, 327);
            this.DetectionInterval_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DetectionInterval_TextBox.Name = "DetectionInterval_TextBox";
            this.DetectionInterval_TextBox.Size = new System.Drawing.Size(89, 31);
            this.DetectionInterval_TextBox.TabIndex = 17;
            //this.DetectionInterval_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EnableStartedTcping_CheckBox
            // 
            this.EnableStartedTcping_CheckBox.AutoSize = true;
            this.EnableStartedTcping_CheckBox.Depth = 0;
            this.EnableStartedTcping_CheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.EnableStartedTcping_CheckBox.Location = new System.Drawing.Point(225, 330);
            this.EnableStartedTcping_CheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnableStartedTcping_CheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.EnableStartedTcping_CheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.EnableStartedTcping_CheckBox.Name = "EnableStartedTcping_CheckBox";
            this.EnableStartedTcping_CheckBox.Ripple = true;
            this.EnableStartedTcping_CheckBox.Size = new System.Drawing.Size(94, 30);
            this.EnableStartedTcping_CheckBox.TabIndex = 15;
            this.EnableStartedTcping_CheckBox.Text = "Enable";
            this.EnableStartedTcping_CheckBox.UseVisualStyleBackColor = true;
            // 
            // DelayTestAfterStartup_Label
            // 
            this.DelayTestAfterStartup_Label.AutoSize = true;
            this.DelayTestAfterStartup_Label.Depth = 0;
            this.DelayTestAfterStartup_Label.Font = new System.Drawing.Font("Roboto", 11F);
            this.DelayTestAfterStartup_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DelayTestAfterStartup_Label.Location = new System.Drawing.Point(18, 332);
            this.DelayTestAfterStartup_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DelayTestAfterStartup_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.DelayTestAfterStartup_Label.Name = "DelayTestAfterStartup_Label";
            this.DelayTestAfterStartup_Label.Size = new System.Drawing.Size(208, 27);
            this.DelayTestAfterStartup_Label.TabIndex = 16;
            this.DelayTestAfterStartup_Label.Text = "Delay test after start";
            // 
            // STUN_ServerPortTextBox
            // 
            this.STUN_ServerPortTextBox.Location = new System.Drawing.Point(225, 410);
            this.STUN_ServerPortTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.STUN_ServerPortTextBox.Name = "STUN_ServerPortTextBox";
            this.STUN_ServerPortTextBox.Size = new System.Drawing.Size(425, 31);
            this.STUN_ServerPortTextBox.TabIndex = 8;
            //this.STUN_ServerPortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // STUNServerPortLabel
            // 
            this.STUNServerPortLabel.AutoSize = true;
            this.STUNServerPortLabel.Depth = 0;
            this.STUNServerPortLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.STUNServerPortLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.STUNServerPortLabel.Location = new System.Drawing.Point(18, 414);
            this.STUNServerPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STUNServerPortLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.STUNServerPortLabel.Name = "STUNServerPortLabel";
            this.STUNServerPortLabel.Size = new System.Drawing.Size(182, 27);
            this.STUNServerPortLabel.TabIndex = 12;
            this.STUNServerPortLabel.Text = "STUN Server Port";
            // 
            // STUNServerLabel
            // 
            this.STUNServerLabel.AutoSize = true;
            this.STUNServerLabel.Depth = 0;
            this.STUNServerLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.STUNServerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.STUNServerLabel.Location = new System.Drawing.Point(18, 375);
            this.STUNServerLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.STUNServerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.STUNServerLabel.Name = "STUNServerLabel";
            this.STUNServerLabel.Size = new System.Drawing.Size(135, 27);
            this.STUNServerLabel.TabIndex = 10;
            this.STUNServerLabel.Text = "STUN Server";
            // 
            // RunAtStartup
            // 
            this.RunAtStartup.AutoSize = true;
            this.RunAtStartup.Depth = 0;
            this.RunAtStartup.Font = new System.Drawing.Font("Roboto", 10F);
            this.RunAtStartup.Location = new System.Drawing.Point(18, 112);
            this.RunAtStartup.Margin = new System.Windows.Forms.Padding(4);
            this.RunAtStartup.MouseLocation = new System.Drawing.Point(-1, -1);
            this.RunAtStartup.MouseState = MaterialSkin.MouseState.HOVER;
            this.RunAtStartup.Name = "RunAtStartup";
            this.RunAtStartup.Ripple = true;
            this.RunAtStartup.Size = new System.Drawing.Size(162, 30);
            this.RunAtStartup.TabIndex = 11;
            this.RunAtStartup.Text = "Run at startup";
            this.RunAtStartup.UseVisualStyleBackColor = true;
            // 
            // STUN_ServerTextBox
            // 
            this.STUN_ServerTextBox.Location = new System.Drawing.Point(225, 366);
            this.STUN_ServerTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.STUN_ServerTextBox.Name = "STUN_ServerTextBox";
            this.STUN_ServerTextBox.Size = new System.Drawing.Size(425, 31);
            this.STUN_ServerTextBox.TabIndex = 11;
            //this.STUN_ServerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MinimizeWhenStartedCheckBox
            // 
            this.MinimizeWhenStartedCheckBox.AutoSize = true;
            this.MinimizeWhenStartedCheckBox.Depth = 0;
            this.MinimizeWhenStartedCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.MinimizeWhenStartedCheckBox.Location = new System.Drawing.Point(309, 72);
            this.MinimizeWhenStartedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeWhenStartedCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.MinimizeWhenStartedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.MinimizeWhenStartedCheckBox.Name = "MinimizeWhenStartedCheckBox";
            this.MinimizeWhenStartedCheckBox.Ripple = true;
            this.MinimizeWhenStartedCheckBox.Size = new System.Drawing.Size(242, 30);
            this.MinimizeWhenStartedCheckBox.TabIndex = 10;
            this.MinimizeWhenStartedCheckBox.Text = "Minimize when started";
            this.MinimizeWhenStartedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ProfileCount_Label
            // 
            this.ProfileCount_Label.AutoSize = true;
            this.ProfileCount_Label.Depth = 0;
            this.ProfileCount_Label.Font = new System.Drawing.Font("Roboto", 11F);
            this.ProfileCount_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ProfileCount_Label.Location = new System.Drawing.Point(18, 294);
            this.ProfileCount_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProfileCount_Label.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProfileCount_Label.Name = "ProfileCount_Label";
            this.ProfileCount_Label.Size = new System.Drawing.Size(133, 27);
            this.ProfileCount_Label.TabIndex = 8;
            this.ProfileCount_Label.Text = "ProfileCount";
            // 
            // ProfileCount_TextBox
            // 
            this.ProfileCount_TextBox.Location = new System.Drawing.Point(379, 290);
            this.ProfileCount_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ProfileCount_TextBox.Name = "ProfileCount_TextBox";
            this.ProfileCount_TextBox.Size = new System.Drawing.Size(272, 31);
            this.ProfileCount_TextBox.TabIndex = 9;
            //this.ProfileCount_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CheckUpdateWhenOpenedCheckBox
            // 
            this.CheckUpdateWhenOpenedCheckBox.AutoSize = true;
            this.CheckUpdateWhenOpenedCheckBox.Depth = 0;
            this.CheckUpdateWhenOpenedCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.CheckUpdateWhenOpenedCheckBox.Location = new System.Drawing.Point(309, 112);
            this.CheckUpdateWhenOpenedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.CheckUpdateWhenOpenedCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.CheckUpdateWhenOpenedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.CheckUpdateWhenOpenedCheckBox.Name = "CheckUpdateWhenOpenedCheckBox";
            this.CheckUpdateWhenOpenedCheckBox.Ripple = true;
            this.CheckUpdateWhenOpenedCheckBox.Size = new System.Drawing.Size(287, 30);
            this.CheckUpdateWhenOpenedCheckBox.TabIndex = 8;
            this.CheckUpdateWhenOpenedCheckBox.Text = "Check update when opened";
            this.CheckUpdateWhenOpenedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.CheckUpdateWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StartWhenOpenedCheckBox
            // 
            this.StartWhenOpenedCheckBox.AutoSize = true;
            this.StartWhenOpenedCheckBox.Depth = 0;
            this.StartWhenOpenedCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.StartWhenOpenedCheckBox.Location = new System.Drawing.Point(18, 72);
            this.StartWhenOpenedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.StartWhenOpenedCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StartWhenOpenedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.StartWhenOpenedCheckBox.Name = "StartWhenOpenedCheckBox";
            this.StartWhenOpenedCheckBox.Ripple = true;
            this.StartWhenOpenedCheckBox.Size = new System.Drawing.Size(205, 30);
            this.StartWhenOpenedCheckBox.TabIndex = 7;
            this.StartWhenOpenedCheckBox.Text = "Start when opened";
            this.StartWhenOpenedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StartWhenOpenedCheckBox.UseVisualStyleBackColor = true;
            // 
            // StopWhenExitedCheckBox
            // 
            this.StopWhenExitedCheckBox.AutoSize = true;
            this.StopWhenExitedCheckBox.Depth = 0;
            this.StopWhenExitedCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.StopWhenExitedCheckBox.Location = new System.Drawing.Point(309, 33);
            this.StopWhenExitedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.StopWhenExitedCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.StopWhenExitedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.StopWhenExitedCheckBox.Name = "StopWhenExitedCheckBox";
            this.StopWhenExitedCheckBox.Ripple = true;
            this.StopWhenExitedCheckBox.Size = new System.Drawing.Size(190, 30);
            this.StopWhenExitedCheckBox.TabIndex = 6;
            this.StopWhenExitedCheckBox.Text = "Stop when exited";
            this.StopWhenExitedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StopWhenExitedCheckBox.UseVisualStyleBackColor = true;
            // 
            // ExitWhenClosedCheckBox
            // 
            this.ExitWhenClosedCheckBox.AutoSize = true;
            this.ExitWhenClosedCheckBox.Depth = 0;
            this.ExitWhenClosedCheckBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.ExitWhenClosedCheckBox.Location = new System.Drawing.Point(18, 32);
            this.ExitWhenClosedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.ExitWhenClosedCheckBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.ExitWhenClosedCheckBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ExitWhenClosedCheckBox.Name = "ExitWhenClosedCheckBox";
            this.ExitWhenClosedCheckBox.Ripple = true;
            this.ExitWhenClosedCheckBox.Size = new System.Drawing.Size(187, 30);
            this.ExitWhenClosedCheckBox.TabIndex = 5;
            this.ExitWhenClosedCheckBox.Text = "Exit when closed";
            this.ExitWhenClosedCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ExitWhenClosedCheckBox.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 500F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.ControlButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.GlobalBypassIPsButton, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 520);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1301, 57);
            this.tableLayoutPanel1.TabIndex = 22;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1336, 585);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.BehaviorGroupBox);
            this.Controls.Add(this.PortGroupBox);
            this.Controls.Add(this.TUNTAPGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingForm_Load);
            this.PortGroupBox.ResumeLayout(false);
            this.PortGroupBox.PerformLayout();
            this.TUNTAPGroupBox.ResumeLayout(false);
            this.TUNTAPGroupBox.PerformLayout();
            this.BehaviorGroupBox.ResumeLayout(false);
            this.BehaviorGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox PortGroupBox;
        private MaterialSkin.Controls.MaterialLabel HTTPPortLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField HTTPPortTextBox;
        private MaterialSkin.Controls.MaterialLabel Socks5PortLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField Socks5PortTextBox;
        private System.Windows.Forms.GroupBox TUNTAPGroupBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField TUNTAPAddressTextBox;
        private MaterialSkin.Controls.MaterialLabel TUNTAPAddressLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TUNTAPNetmaskTextBox;
        private MaterialSkin.Controls.MaterialLabel TUNTAPNetmaskLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TUNTAPGatewayTextBox;
        private MaterialSkin.Controls.MaterialLabel TUNTAPGatewayLabel;
        private MaterialSkin.Controls.MaterialLabel TUNTAPDNSLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField TUNTAPDNSTextBox;
        private MaterialSkin.Controls.MaterialFlatButton ControlButton;
        private MaterialSkin.Controls.MaterialFlatButton GlobalBypassIPsButton;
        private MaterialSkin.Controls.MaterialCheckBox UseCustomDNSCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox AllowDevicesCheckBox;
        private System.Windows.Forms.GroupBox BehaviorGroupBox;
        private MaterialSkin.Controls.MaterialCheckBox ExitWhenClosedCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox StopWhenExitedCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox StartWhenOpenedCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox CheckUpdateWhenOpenedCheckBox;
        private MaterialSkin.Controls.MaterialLabel ProfileCount_Label;
        private MaterialSkin.Controls.MaterialSingleLineTextField ProfileCount_TextBox;
        private MaterialSkin.Controls.MaterialCheckBox MinimizeWhenStartedCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox RunAtStartup;
        private MaterialSkin.Controls.MaterialLabel STUNServerPortLabel;
        private MaterialSkin.Controls.MaterialLabel STUNServerLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField STUN_ServerTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField STUN_ServerPortTextBox;
        private MaterialSkin.Controls.MaterialCheckBox ProxyDNSCheckBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField DetectionInterval_TextBox;
        private MaterialSkin.Controls.MaterialCheckBox EnableStartedTcping_CheckBox;
        private MaterialSkin.Controls.MaterialLabel DelayTestAfterStartup_Label;
        private MaterialSkin.Controls.MaterialLabel DetectionInterval_Label;
        private MaterialSkin.Controls.MaterialLabel RedirectorLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField RedirectorTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField AclAddr;
        private MaterialSkin.Controls.MaterialLabel AclLabel;
        private MaterialSkin.Controls.MaterialCheckBox UseFakeDNSCheckBox;
        private MaterialSkin.Controls.MaterialCheckBox BootShadowsocksFromDLLCheckBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}