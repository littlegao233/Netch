namespace Netch.Forms.Server
{
    partial class VMess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VMess));
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.UseMuxCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.TLSSecureCheckBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.QUICSecretLabel = new MaterialSkin.Controls.MaterialLabel();
            this.QUICSecurityLabel = new MaterialSkin.Controls.MaterialLabel();
            this.QUICSecretTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.QUICSecurityComboBox = new System.Windows.Forms.ComboBox();
            this.PathLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PathTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.HostLabel = new MaterialSkin.Controls.MaterialLabel();
            this.HostTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.FakeTypeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.FakeTypeComboBox = new System.Windows.Forms.ComboBox();
            this.TransferProtocolLabel = new MaterialSkin.Controls.MaterialLabel();
            this.TransferProtocolComboBox = new System.Windows.Forms.ComboBox();
            this.EncryptMethodLabel = new MaterialSkin.Controls.MaterialLabel();
            this.EncryptMethodComboBox = new System.Windows.Forms.ComboBox();
            this.AlterIDLabel = new MaterialSkin.Controls.MaterialLabel();
            this.AlterIDTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.UserIDLabel = new MaterialSkin.Controls.MaterialLabel();
            this.UserIDTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.PortTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AddressTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.AddressLabel = new MaterialSkin.Controls.MaterialLabel();
            this.RemarkTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RemarkLabel = new MaterialSkin.Controls.MaterialLabel();
            this.PortLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ControlButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ConfigurationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.Controls.Add(this.UseMuxCheckBox);
            this.ConfigurationGroupBox.Controls.Add(this.TLSSecureCheckBox);
            this.ConfigurationGroupBox.Controls.Add(this.QUICSecretLabel);
            this.ConfigurationGroupBox.Controls.Add(this.QUICSecurityLabel);
            this.ConfigurationGroupBox.Controls.Add(this.QUICSecretTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.QUICSecurityComboBox);
            this.ConfigurationGroupBox.Controls.Add(this.PathLabel);
            this.ConfigurationGroupBox.Controls.Add(this.PathTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.HostLabel);
            this.ConfigurationGroupBox.Controls.Add(this.HostTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.FakeTypeLabel);
            this.ConfigurationGroupBox.Controls.Add(this.FakeTypeComboBox);
            this.ConfigurationGroupBox.Controls.Add(this.TransferProtocolLabel);
            this.ConfigurationGroupBox.Controls.Add(this.TransferProtocolComboBox);
            this.ConfigurationGroupBox.Controls.Add(this.EncryptMethodLabel);
            this.ConfigurationGroupBox.Controls.Add(this.EncryptMethodComboBox);
            this.ConfigurationGroupBox.Controls.Add(this.AlterIDLabel);
            this.ConfigurationGroupBox.Controls.Add(this.AlterIDTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.UserIDLabel);
            this.ConfigurationGroupBox.Controls.Add(this.UserIDTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.PortTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.AddressTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.AddressLabel);
            this.ConfigurationGroupBox.Controls.Add(this.RemarkTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.RemarkLabel);
            this.ConfigurationGroupBox.Controls.Add(this.PortLabel);
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(18, 18);
            this.ConfigurationGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(630, 560);
            this.ConfigurationGroupBox.TabIndex = 1;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Configuration";
            // 
            // UseMuxCheckBox
            // 
            this.UseMuxCheckBox.AutoSize = true;
            this.UseMuxCheckBox.Location = new System.Drawing.Point(292, 519);
            this.UseMuxCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.UseMuxCheckBox.Name = "UseMuxCheckBox";
            this.UseMuxCheckBox.Size = new System.Drawing.Size(110, 28);
            this.UseMuxCheckBox.TabIndex = 25;
            this.UseMuxCheckBox.Text = "Use Mux";
            this.UseMuxCheckBox.UseVisualStyleBackColor = true;
            // 
            // TLSSecureCheckBox
            // 
            this.TLSSecureCheckBox.AutoSize = true;
            this.TLSSecureCheckBox.Location = new System.Drawing.Point(453, 519);
            this.TLSSecureCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.TLSSecureCheckBox.Name = "TLSSecureCheckBox";
            this.TLSSecureCheckBox.Size = new System.Drawing.Size(127, 28);
            this.TLSSecureCheckBox.TabIndex = 24;
            this.TLSSecureCheckBox.Text = "TLS Secure";
            this.TLSSecureCheckBox.UseVisualStyleBackColor = true;
            // 
            // QUICSecretLabel
            // 
            this.QUICSecretLabel.AutoSize = true;
            this.QUICSecretLabel.Location = new System.Drawing.Point(15, 480);
            this.QUICSecretLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QUICSecretLabel.Name = "QUICSecretLabel";
            this.QUICSecretLabel.Size = new System.Drawing.Size(113, 24);
            this.QUICSecretLabel.TabIndex = 22;
            this.QUICSecretLabel.Text = "QUIC Secret";
            // 
            // QUICSecurityLabel
            // 
            this.QUICSecurityLabel.AutoSize = true;
            this.QUICSecurityLabel.Location = new System.Drawing.Point(15, 435);
            this.QUICSecurityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.QUICSecurityLabel.Name = "QUICSecurityLabel";
            this.QUICSecurityLabel.Size = new System.Drawing.Size(129, 24);
            this.QUICSecurityLabel.TabIndex = 20;
            this.QUICSecurityLabel.Text = "QUIC Security";
            // 
            // QUICSecretTextBox
            // 
            this.QUICSecretTextBox.Location = new System.Drawing.Point(180, 476);
            this.QUICSecretTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.QUICSecretTextBox.Name = "QUICSecretTextBox";
            this.QUICSecretTextBox.Size = new System.Drawing.Size(439, 31);
            this.QUICSecretTextBox.TabIndex = 23;
            // 
            // QUICSecurityComboBox
            // 
            this.QUICSecurityComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.QUICSecurityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QUICSecurityComboBox.FormattingEnabled = true;
            this.QUICSecurityComboBox.Location = new System.Drawing.Point(180, 429);
            this.QUICSecurityComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.QUICSecurityComboBox.Name = "QUICSecurityComboBox";
            this.QUICSecurityComboBox.Size = new System.Drawing.Size(439, 32);
            this.QUICSecurityComboBox.TabIndex = 21;
            this.QUICSecurityComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // PathLabel
            // 
            this.PathLabel.AutoSize = true;
            this.PathLabel.Location = new System.Drawing.Point(15, 390);
            this.PathLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PathLabel.Name = "PathLabel";
            this.PathLabel.Size = new System.Drawing.Size(49, 24);
            this.PathLabel.TabIndex = 18;
            this.PathLabel.Text = "Path";
            // 
            // PathTextBox
            // 
            this.PathTextBox.Location = new System.Drawing.Point(180, 386);
            this.PathTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.Size = new System.Drawing.Size(439, 31);
            this.PathTextBox.TabIndex = 19;
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.Location = new System.Drawing.Point(15, 346);
            this.HostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(50, 24);
            this.HostLabel.TabIndex = 16;
            this.HostLabel.Text = "Host";
            // 
            // HostTextBox
            // 
            this.HostTextBox.Location = new System.Drawing.Point(180, 342);
            this.HostTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.HostTextBox.Name = "HostTextBox";
            this.HostTextBox.Size = new System.Drawing.Size(439, 31);
            this.HostTextBox.TabIndex = 17;
            // 
            // FakeTypeLabel
            // 
            this.FakeTypeLabel.AutoSize = true;
            this.FakeTypeLabel.Location = new System.Drawing.Point(15, 302);
            this.FakeTypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FakeTypeLabel.Name = "FakeTypeLabel";
            this.FakeTypeLabel.Size = new System.Drawing.Size(97, 24);
            this.FakeTypeLabel.TabIndex = 14;
            this.FakeTypeLabel.Text = "Fake Type";
            // 
            // FakeTypeComboBox
            // 
            this.FakeTypeComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.FakeTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FakeTypeComboBox.FormattingEnabled = true;
            this.FakeTypeComboBox.Location = new System.Drawing.Point(180, 296);
            this.FakeTypeComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FakeTypeComboBox.Name = "FakeTypeComboBox";
            this.FakeTypeComboBox.Size = new System.Drawing.Size(439, 32);
            this.FakeTypeComboBox.TabIndex = 15;
            this.FakeTypeComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // TransferProtocolLabel
            // 
            this.TransferProtocolLabel.AutoSize = true;
            this.TransferProtocolLabel.Location = new System.Drawing.Point(15, 255);
            this.TransferProtocolLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TransferProtocolLabel.Name = "TransferProtocolLabel";
            this.TransferProtocolLabel.Size = new System.Drawing.Size(156, 24);
            this.TransferProtocolLabel.TabIndex = 12;
            this.TransferProtocolLabel.Text = "Transfer Protocol";
            // 
            // TransferProtocolComboBox
            // 
            this.TransferProtocolComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TransferProtocolComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransferProtocolComboBox.FormattingEnabled = true;
            this.TransferProtocolComboBox.Location = new System.Drawing.Point(180, 249);
            this.TransferProtocolComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.TransferProtocolComboBox.Name = "TransferProtocolComboBox";
            this.TransferProtocolComboBox.Size = new System.Drawing.Size(439, 32);
            this.TransferProtocolComboBox.TabIndex = 13;
            this.TransferProtocolComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // EncryptMethodLabel
            // 
            this.EncryptMethodLabel.AutoSize = true;
            this.EncryptMethodLabel.Location = new System.Drawing.Point(15, 208);
            this.EncryptMethodLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EncryptMethodLabel.Name = "EncryptMethodLabel";
            this.EncryptMethodLabel.Size = new System.Drawing.Size(150, 24);
            this.EncryptMethodLabel.TabIndex = 10;
            this.EncryptMethodLabel.Text = "Encrypt Method";
            // 
            // EncryptMethodComboBox
            // 
            this.EncryptMethodComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EncryptMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncryptMethodComboBox.FormattingEnabled = true;
            this.EncryptMethodComboBox.Location = new System.Drawing.Point(180, 202);
            this.EncryptMethodComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.EncryptMethodComboBox.Name = "EncryptMethodComboBox";
            this.EncryptMethodComboBox.Size = new System.Drawing.Size(439, 32);
            this.EncryptMethodComboBox.TabIndex = 11;
            this.EncryptMethodComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // AlterIDLabel
            // 
            this.AlterIDLabel.AutoSize = true;
            this.AlterIDLabel.Location = new System.Drawing.Point(15, 164);
            this.AlterIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlterIDLabel.Name = "AlterIDLabel";
            this.AlterIDLabel.Size = new System.Drawing.Size(76, 24);
            this.AlterIDLabel.TabIndex = 8;
            this.AlterIDLabel.Text = "Alter ID";
            // 
            // AlterIDTextBox
            // 
            this.AlterIDTextBox.Location = new System.Drawing.Point(180, 159);
            this.AlterIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AlterIDTextBox.Name = "AlterIDTextBox";
            this.AlterIDTextBox.Size = new System.Drawing.Size(79, 31);
            this.AlterIDTextBox.TabIndex = 9;
            // 
            // UserIDLabel
            // 
            this.UserIDLabel.AutoSize = true;
            this.UserIDLabel.Location = new System.Drawing.Point(15, 120);
            this.UserIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserIDLabel.Name = "UserIDLabel";
            this.UserIDLabel.Size = new System.Drawing.Size(72, 24);
            this.UserIDLabel.TabIndex = 6;
            this.UserIDLabel.Text = "User ID";
            // 
            // UserIDTextBox
            // 
            this.UserIDTextBox.Location = new System.Drawing.Point(180, 116);
            this.UserIDTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.UserIDTextBox.Name = "UserIDTextBox";
            this.UserIDTextBox.Size = new System.Drawing.Size(439, 31);
            this.UserIDTextBox.TabIndex = 7;
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(540, 72);
            this.PortTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(79, 31);
            this.PortTextBox.TabIndex = 5;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(180, 72);
            this.AddressTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(349, 31);
            this.AddressTextBox.TabIndex = 3;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(15, 76);
            this.AddressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(80, 24);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "Address";
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Location = new System.Drawing.Point(180, 28);
            this.RemarkTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(439, 31);
            this.RemarkTextBox.TabIndex = 1;
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Location = new System.Drawing.Point(15, 33);
            this.RemarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(76, 24);
            this.RemarkLabel.TabIndex = 0;
            this.RemarkLabel.Text = "Remark";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(530, 76);
            this.PortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(14, 24);
            this.PortLabel.TabIndex = 4;
            this.PortLabel.Text = ":";
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(536, 586);
            this.ControlButton.Margin = new System.Windows.Forms.Padding(4);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(112, 34);
            this.ControlButton.TabIndex = 2;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // VMess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(666, 639);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "VMess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VMess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VMess_FormClosing);
            this.Load += new System.EventHandler(this.VMess_Load);
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField PortTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField AddressTextBox;
        private MaterialSkin.Controls.MaterialLabel AddressLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField RemarkTextBox;
        private MaterialSkin.Controls.MaterialLabel RemarkLabel;
        private MaterialSkin.Controls.MaterialLabel PortLabel;
        private MaterialSkin.Controls.MaterialLabel UserIDLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField UserIDTextBox;
        private MaterialSkin.Controls.MaterialLabel AlterIDLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField AlterIDTextBox;
        private MaterialSkin.Controls.MaterialLabel EncryptMethodLabel;
        private System.Windows.Forms.ComboBox EncryptMethodComboBox;
        private MaterialSkin.Controls.MaterialLabel TransferProtocolLabel;
        private System.Windows.Forms.ComboBox TransferProtocolComboBox;
        private MaterialSkin.Controls.MaterialLabel FakeTypeLabel;
        private System.Windows.Forms.ComboBox FakeTypeComboBox;
        private MaterialSkin.Controls.MaterialLabel HostLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField HostTextBox;
        private MaterialSkin.Controls.MaterialLabel PathLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField PathTextBox;
        private MaterialSkin.Controls.MaterialLabel QUICSecurityLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField QUICSecretTextBox;
        private System.Windows.Forms.ComboBox QUICSecurityComboBox;
        private MaterialSkin.Controls.MaterialLabel QUICSecretLabel;
        private MaterialSkin.Controls.MaterialCheckBox TLSSecureCheckBox;
        private MaterialSkin.Controls.MaterialFlatButton ControlButton;
        private MaterialSkin.Controls.MaterialCheckBox UseMuxCheckBox;
    }
}