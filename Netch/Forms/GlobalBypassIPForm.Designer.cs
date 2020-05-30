namespace Netch.Forms
{
    partial class GlobalBypassIPForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GlobalBypassIPForm));
            this.IPGroupBox = new System.Windows.Forms.GroupBox();
            this.AddButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.DeleteButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.PrefixComboBox = new System.Windows.Forms.ComboBox();
            this.IPTextBox = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.IPListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ControlButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.IPGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // IPGroupBox
            // 
            this.IPGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.IPGroupBox.Controls.Add(this.PrefixComboBox);
            this.IPGroupBox.Controls.Add(this.IPTextBox);
            this.IPGroupBox.Controls.Add(this.IPListBox);
            this.IPGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.IPGroupBox.Location = new System.Drawing.Point(0, 0);
            this.IPGroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPGroupBox.Name = "IPGroupBox";
            this.IPGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPGroupBox.Size = new System.Drawing.Size(510, 462);
            this.IPGroupBox.TabIndex = 0;
            this.IPGroupBox.TabStop = false;
            this.IPGroupBox.Text = "IPs";
            // 
            // AddButton
            // 
            this.AddButton.AutoSize = true;
            this.AddButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AddButton.Depth = 0;
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(6, 9);
            this.AddButton.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.AddButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.AddButton.Name = "AddButton";
            this.AddButton.Primary = false;
            this.AddButton.Size = new System.Drawing.Size(239, 47);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSize = true;
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.Depth = 0;
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton.Location = new System.Drawing.Point(257, 9);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(6, 9, 6, 9);
            this.DeleteButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Primary = false;
            this.DeleteButton.Size = new System.Drawing.Size(239, 47);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // PrefixComboBox
            // 
            this.PrefixComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PrefixComboBox.FormattingEnabled = true;
            this.PrefixComboBox.IntegralHeight = false;
            this.PrefixComboBox.Location = new System.Drawing.Point(400, 354);
            this.PrefixComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PrefixComboBox.MaxDropDownItems = 4;
            this.PrefixComboBox.Name = "PrefixComboBox";
            this.PrefixComboBox.Size = new System.Drawing.Size(104, 32);
            this.PrefixComboBox.TabIndex = 2;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(4, 354);
            this.IPTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(388, 31);
            this.IPTextBox.TabIndex = 1;
            // 
            // IPListBox
            // 
            this.IPListBox.FormattingEnabled = true;
            this.IPListBox.ItemHeight = 24;
            this.IPListBox.Location = new System.Drawing.Point(6, 33);
            this.IPListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPListBox.Name = "IPListBox";
            this.IPListBox.Size = new System.Drawing.Size(496, 316);
            this.IPListBox.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(4, 393);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(502, 65);
            this.tableLayoutPanel1.TabIndex = 16;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.ControlButton, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 471);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(510, 65);
            this.tableLayoutPanel2.TabIndex = 17;
            // 
            // ControlButton
            // 
            this.ControlButton.Depth = 0;
            this.ControlButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlButton.Location = new System.Drawing.Point(3, 3);
            this.ControlButton.Margin = new System.Windows.Forms.Padding(3, 3, 3, 15);
            this.ControlButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Padding = new System.Windows.Forms.Padding(0, 30, 0, 0);
            this.ControlButton.Primary = false;
            this.ControlButton.Size = new System.Drawing.Size(504, 47);
            this.ControlButton.TabIndex = 3;
            this.ControlButton.Text = "Save";
            this.ControlButton.UseVisualStyleBackColor = true;
            // 
            // GlobalBypassIPForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(510, 536);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.IPGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.MaximizeBox = false;
            this.Name = "GlobalBypassIPForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Global Bypass IPs";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GlobalBypassIPForm_FormClosing);
            this.Load += new System.EventHandler(this.GlobalBypassIPForm_Load);
            this.IPGroupBox.ResumeLayout(false);
            this.IPGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox IPGroupBox;
        private System.Windows.Forms.ListBox IPListBox;
        private System.Windows.Forms.ComboBox PrefixComboBox;
        private MaterialSkin.Controls.MaterialSingleLineTextField IPTextBox;
        private MaterialSkin.Controls.MaterialFlatButton DeleteButton;
        private MaterialSkin.Controls.MaterialFlatButton AddButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private MaterialSkin.Controls.MaterialFlatButton ControlButton;
    }
}