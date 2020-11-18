namespace DiscordDataPackageParser
{
    partial class DiscordDataPackageParserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiscordDataPackageParserForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.explorerListBox = new System.Windows.Forms.ListBox();
            this.openButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabAbout = new System.Windows.Forms.TabPage();
            this.tabEditor = new System.Windows.Forms.TabPage();
            this.tabData = new System.Windows.Forms.TabPage();
            this.dataDataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.explorerListBox);
            this.groupBox1.Controls.Add(this.openButton);
            this.groupBox1.Location = new System.Drawing.Point(13, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(263, 571);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Explorer";
            // 
            // explorerListBox
            // 
            this.explorerListBox.FormattingEnabled = true;
            this.explorerListBox.Location = new System.Drawing.Point(7, 75);
            this.explorerListBox.Name = "explorerListBox";
            this.explorerListBox.Size = new System.Drawing.Size(250, 485);
            this.explorerListBox.TabIndex = 1;
            this.explorerListBox.SelectedIndexChanged += new System.EventHandler(this.ExplorerListBox_SelectedIndexChanged);
            // 
            // openButton
            // 
            this.openButton.Location = new System.Drawing.Point(6, 19);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(250, 50);
            this.openButton.TabIndex = 0;
            this.openButton.Text = "Open";
            this.openButton.UseVisualStyleBackColor = true;
            this.openButton.Click += new System.EventHandler(this.OpenButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(6, 44);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(251, 26);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(251, 20);
            this.textBox1.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.loginButton);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 589);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 80);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Login";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(283, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(969, 656);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tabAbout
            // 
            this.tabAbout.Location = new System.Drawing.Point(4, 22);
            this.tabAbout.Name = "tabAbout";
            this.tabAbout.Padding = new System.Windows.Forms.Padding(3);
            this.tabAbout.Size = new System.Drawing.Size(949, 605);
            this.tabAbout.TabIndex = 1;
            this.tabAbout.Text = "About";
            this.tabAbout.UseVisualStyleBackColor = true;
            // 
            // tabEditor
            // 
            this.tabEditor.Location = new System.Drawing.Point(4, 22);
            this.tabEditor.Name = "tabEditor";
            this.tabEditor.Padding = new System.Windows.Forms.Padding(3);
            this.tabEditor.Size = new System.Drawing.Size(949, 605);
            this.tabEditor.TabIndex = 2;
            this.tabEditor.Text = "Editor";
            this.tabEditor.UseVisualStyleBackColor = true;
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dataDataGridView);
            this.tabData.Location = new System.Drawing.Point(4, 22);
            this.tabData.Name = "tabData";
            this.tabData.Padding = new System.Windows.Forms.Padding(3);
            this.tabData.Size = new System.Drawing.Size(949, 605);
            this.tabData.TabIndex = 0;
            this.tabData.Text = "Data";
            this.tabData.UseVisualStyleBackColor = true;
            // 
            // dataDataGridView
            // 
            this.dataDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataDataGridView.Location = new System.Drawing.Point(6, 7);
            this.dataDataGridView.Name = "dataDataGridView";
            this.dataDataGridView.Size = new System.Drawing.Size(937, 592);
            this.dataDataGridView.TabIndex = 3;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabData);
            this.tabControl1.Controls.Add(this.tabEditor);
            this.tabControl1.Controls.Add(this.tabAbout);
            this.tabControl1.Location = new System.Drawing.Point(6, 19);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 631);
            this.tabControl1.TabIndex = 2;
            // 
            // DiscordDataPackageParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiscordDataPackageParserForm";
            this.Text = "DiscordDataPackageParser";
            this.Load += new System.EventHandler(this.DiscordDataPackageParserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.tabData.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataDataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.ListBox explorerListBox;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabData;
        private System.Windows.Forms.DataGridView dataDataGridView;
        private System.Windows.Forms.TabPage tabEditor;
        private System.Windows.Forms.TabPage tabAbout;
    }
}

