namespace Netch.Forms.Mode
{
    partial class Process
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Process));
            this.ConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.UseCustomFilenameBox = new MaterialSkin.Controls.MaterialCheckBox();
            this.TimeDataButton = new System.Windows.Forms.RadioButton();
            this.StaySameButton = new System.Windows.Forms.RadioButton();
            this.FilenameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.FilenameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.ScanButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ProcessGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ProcessNameTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RuleListBox = new System.Windows.Forms.ListBox();
            this.RemarkTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.RemarkLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ControlButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.ConfigurationGroupBox.SuspendLayout();
            this.ProcessGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ConfigurationGroupBox
            // 
            this.ConfigurationGroupBox.Controls.Add(this.UseCustomFilenameBox);
            this.ConfigurationGroupBox.Controls.Add(this.TimeDataButton);
            this.ConfigurationGroupBox.Controls.Add(this.StaySameButton);
            this.ConfigurationGroupBox.Controls.Add(this.FilenameLabel);
            this.ConfigurationGroupBox.Controls.Add(this.FilenameTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.ScanButton);
            this.ConfigurationGroupBox.Controls.Add(this.ProcessGroupBox);
            this.ConfigurationGroupBox.Controls.Add(this.RuleListBox);
            this.ConfigurationGroupBox.Controls.Add(this.RemarkTextBox);
            this.ConfigurationGroupBox.Controls.Add(this.RemarkLabel);
            this.ConfigurationGroupBox.Location = new System.Drawing.Point(18, 18);
            this.ConfigurationGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfigurationGroupBox.Name = "ConfigurationGroupBox";
            this.ConfigurationGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ConfigurationGroupBox.Size = new System.Drawing.Size(510, 516);
            this.ConfigurationGroupBox.TabIndex = 0;
            this.ConfigurationGroupBox.TabStop = false;
            this.ConfigurationGroupBox.Text = "Configuration";
            // 
            // UseCustomFilenameBox
            // 
            this.UseCustomFilenameBox.AutoSize = true;
            this.UseCustomFilenameBox.Depth = 0;
            this.UseCustomFilenameBox.Font = new System.Drawing.Font("Roboto", 10F);
            this.UseCustomFilenameBox.Location = new System.Drawing.Point(126, 123);
            this.UseCustomFilenameBox.Margin = new System.Windows.Forms.Padding(0);
            this.UseCustomFilenameBox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.UseCustomFilenameBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.UseCustomFilenameBox.Name = "UseCustomFilenameBox";
            this.UseCustomFilenameBox.Ripple = true;
            this.UseCustomFilenameBox.Size = new System.Drawing.Size(234, 30);
            this.UseCustomFilenameBox.TabIndex = 9;
            this.UseCustomFilenameBox.Text = "Use Custom Filename";
            this.UseCustomFilenameBox.UseVisualStyleBackColor = true;
            this.UseCustomFilenameBox.CheckedChanged += new System.EventHandler(this.UseCustomFileNameBox_CheckedChanged);
            // 
            // TimeDataButton
            // 
            this.TimeDataButton.AutoSize = true;
            this.TimeDataButton.Location = new System.Drawing.Point(296, 159);
            this.TimeDataButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TimeDataButton.Name = "TimeDataButton";
            this.TimeDataButton.Size = new System.Drawing.Size(121, 28);
            this.TimeDataButton.TabIndex = 8;
            this.TimeDataButton.TabStop = true;
            this.TimeDataButton.Text = "Time data";
            this.TimeDataButton.UseVisualStyleBackColor = true;
            // 
            // StaySameButton
            // 
            this.StaySameButton.AutoSize = true;
            this.StaySameButton.Location = new System.Drawing.Point(126, 159);
            this.StaySameButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.StaySameButton.Name = "StaySameButton";
            this.StaySameButton.Size = new System.Drawing.Size(155, 28);
            this.StaySameButton.TabIndex = 7;
            this.StaySameButton.TabStop = true;
            this.StaySameButton.Text = "Stay the same";
            this.StaySameButton.UseVisualStyleBackColor = true;
            // 
            // FilenameLabel
            // 
            this.FilenameLabel.AutoSize = true;
            this.FilenameLabel.Depth = 0;
            this.FilenameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.FilenameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.FilenameLabel.Location = new System.Drawing.Point(18, 82);
            this.FilenameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FilenameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.FilenameLabel.Name = "FilenameLabel";
            this.FilenameLabel.Size = new System.Drawing.Size(101, 27);
            this.FilenameLabel.TabIndex = 6;
            this.FilenameLabel.Text = "Filename";
            // 
            // FilenameTextBox
            // 
            this.FilenameTextBox.Depth = 0;
            this.FilenameTextBox.Hint = "";
            this.FilenameTextBox.Location = new System.Drawing.Point(126, 78);
            this.FilenameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.FilenameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.FilenameTextBox.Name = "FilenameTextBox";
            this.FilenameTextBox.PasswordChar = '\0';
            this.FilenameTextBox.SelectedText = "";
            this.FilenameTextBox.SelectionLength = 0;
            this.FilenameTextBox.SelectionStart = 0;
            this.FilenameTextBox.Size = new System.Drawing.Size(375, 32);
            this.FilenameTextBox.TabIndex = 5;
            this.FilenameTextBox.UseSystemPasswordChar = false;
            // 
            // ScanButton
            // 
            this.ScanButton.AutoSize = true;
            this.ScanButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ScanButton.Depth = 0;
            this.ScanButton.Location = new System.Drawing.Point(9, 472);
            this.ScanButton.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ScanButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ScanButton.Name = "ScanButton";
            this.ScanButton.Primary = false;
            this.ScanButton.Size = new System.Drawing.Size(68, 36);
            this.ScanButton.TabIndex = 4;
            this.ScanButton.Text = "Scan";
            this.ScanButton.UseVisualStyleBackColor = true;
            this.ScanButton.Click += new System.EventHandler(this.ScanButton_Click);
            // 
            // ProcessGroupBox
            // 
            this.ProcessGroupBox.Controls.Add(this.AddButton);
            this.ProcessGroupBox.Controls.Add(this.ProcessNameTextBox);
            this.ProcessGroupBox.Location = new System.Drawing.Point(9, 394);
            this.ProcessGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessGroupBox.Name = "ProcessGroupBox";
            this.ProcessGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessGroupBox.Size = new System.Drawing.Size(492, 69);
            this.ProcessGroupBox.TabIndex = 3;
            this.ProcessGroupBox.TabStop = false;
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Depth = 0;
            this.AddButton.Location = new System.Drawing.Point(370, 22);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = false;
            this.AddButton.Size = new System.Drawing.Size(55, 36);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProcessNameTextBox
            // 
            this.ProcessNameTextBox.Depth = 0;
            this.ProcessNameTextBox.Hint = "";
            this.ProcessNameTextBox.Location = new System.Drawing.Point(14, 22);
            this.ProcessNameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProcessNameTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.ProcessNameTextBox.Name = "ProcessNameTextBox";
            this.ProcessNameTextBox.PasswordChar = '\0';
            this.ProcessNameTextBox.SelectedText = "";
            this.ProcessNameTextBox.SelectionLength = 0;
            this.ProcessNameTextBox.SelectionStart = 0;
            this.ProcessNameTextBox.Size = new System.Drawing.Size(333, 32);
            this.ProcessNameTextBox.TabIndex = 0;
            this.ProcessNameTextBox.UseSystemPasswordChar = false;
            this.ProcessNameTextBox.Click += new System.EventHandler(this.ProcessNameTextBox_Click);
            // 
            // RuleListBox
            // 
            this.RuleListBox.FormattingEnabled = true;
            this.RuleListBox.ItemHeight = 24;
            this.RuleListBox.Location = new System.Drawing.Point(9, 201);
            this.RuleListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RuleListBox.Name = "RuleListBox";
            this.RuleListBox.Size = new System.Drawing.Size(490, 172);
            this.RuleListBox.TabIndex = 2;
            this.RuleListBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RuleListBox_MouseUp);
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Depth = 0;
            this.RemarkTextBox.Hint = "";
            this.RemarkTextBox.Location = new System.Drawing.Point(126, 33);
            this.RemarkTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemarkTextBox.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.PasswordChar = '\0';
            this.RemarkTextBox.SelectedText = "";
            this.RemarkTextBox.SelectionLength = 0;
            this.RemarkTextBox.SelectionStart = 0;
            this.RemarkTextBox.Size = new System.Drawing.Size(375, 32);
            this.RemarkTextBox.TabIndex = 1;
            this.RemarkTextBox.UseSystemPasswordChar = false;
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Depth = 0;
            this.RemarkLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.RemarkLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.RemarkLabel.Location = new System.Drawing.Point(18, 38);
            this.RemarkLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemarkLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(87, 27);
            this.RemarkLabel.TabIndex = 0;
            this.RemarkLabel.Text = "Remark";
            // 
            // ControlButton
            // 
            this.ControlButton.AutoSize = true;
            this.ControlButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ControlButton.Depth = 0;
            this.ControlButton.Location = new System.Drawing.Point(416, 543);
            this.ControlButton.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.ControlButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Primary = false;
            this.ControlButton.Size = new System.Drawing.Size(65, 36);
            this.ControlButton.TabIndex = 1;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // Process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(546, 596);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.ConfigurationGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "Process";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Process Mode";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModeForm_FormClosing);
            this.Load += new System.EventHandler(this.ModeForm_Load);
            this.ConfigurationGroupBox.ResumeLayout(false);
            this.ConfigurationGroupBox.PerformLayout();
            this.ProcessGroupBox.ResumeLayout(false);
            this.ProcessGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox ConfigurationGroupBox;
        private MaterialSkin.Controls.MaterialLabel RemarkLabel;
        private System.Windows.Forms.GroupBox ProcessGroupBox;
        private System.Windows.Forms.ListBox RuleListBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField RemarkTextBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField ProcessNameTextBox;
        private MaterialSkin.Controls.MaterialFlatButton AddButton;
        private MaterialSkin.Controls.MaterialFlatButton ScanButton;
        private MaterialSkin.Controls.MaterialFlatButton ControlButton;
        private MaterialSkin.Controls.MaterialLabel FilenameLabel;
        private MaterialSkin.Controls.MaterialSingleLineTextField FilenameTextBox;
        private System.Windows.Forms.RadioButton StaySameButton;
        private System.Windows.Forms.RadioButton TimeDataButton;
        private MaterialSkin.Controls.MaterialCheckBox UseCustomFilenameBox;
    }
}