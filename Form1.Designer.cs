
namespace PhotoGrabber
{   
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.startSearchBtn = new System.Windows.Forms.Button();
            this.btnStopProcess = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.typeInput = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.folderInput = new System.Windows.Forms.TextBox();
            this.filterInput = new System.Windows.Forms.TextBox();
            this.linkTypeBox = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.CheckBox();
            this.Subreddit = new System.Windows.Forms.CheckBox();
            this.Random = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.limitInput = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.status = new System.Windows.Forms.TextBox();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.mediaType = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // startSearchBtn
            // 
            this.startSearchBtn.BackColor = System.Drawing.Color.Lime;
            this.startSearchBtn.Location = new System.Drawing.Point(348, 393);
            this.startSearchBtn.Name = "startSearchBtn";
            this.startSearchBtn.Size = new System.Drawing.Size(151, 29);
            this.startSearchBtn.TabIndex = 0;
            this.startSearchBtn.Text = "Start Search";
            this.startSearchBtn.UseVisualStyleBackColor = false;
            this.startSearchBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStopProcess
            // 
            this.btnStopProcess.Location = new System.Drawing.Point(191, 393);
            this.btnStopProcess.Name = "btnStopProcess";
            this.btnStopProcess.Size = new System.Drawing.Size(151, 29);
            this.btnStopProcess.TabIndex = 1;
            this.btnStopProcess.Text = "Stop Search";
            this.btnStopProcess.UseVisualStyleBackColor = true;
            this.btnStopProcess.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(308, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // typeInput
            // 
            this.typeInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.typeInput.Location = new System.Drawing.Point(53, 146);
            this.typeInput.Name = "typeInput";
            this.typeInput.Size = new System.Drawing.Size(132, 27);
            this.typeInput.TabIndex = 3;
            this.typeInput.Text = "Subreddit or User";
            this.typeInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.typeInput.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(308, 27);
            this.textBox3.TabIndex = 4;
            // 
            // folderInput
            // 
            this.folderInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.folderInput.Location = new System.Drawing.Point(53, 194);
            this.folderInput.Name = "folderInput";
            this.folderInput.Size = new System.Drawing.Size(132, 27);
            this.folderInput.TabIndex = 5;
            this.folderInput.Text = "Folder Name";
            this.folderInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // filterInput
            // 
            this.filterInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.filterInput.Location = new System.Drawing.Point(53, 241);
            this.filterInput.Name = "filterInput";
            this.filterInput.Size = new System.Drawing.Size(132, 27);
            this.filterInput.TabIndex = 7;
            this.filterInput.Text = "Filter By";
            this.filterInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.filterInput.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // linkTypeBox
            // 
            this.linkTypeBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.linkTypeBox.Location = new System.Drawing.Point(53, 100);
            this.linkTypeBox.Name = "linkTypeBox";
            this.linkTypeBox.Size = new System.Drawing.Size(132, 27);
            this.linkTypeBox.TabIndex = 12;
            this.linkTypeBox.Text = "Reddit Link Type";
            this.linkTypeBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // User
            // 
            this.User.AutoSize = true;
            this.User.Location = new System.Drawing.Point(191, 103);
            this.User.Name = "User";
            this.User.Size = new System.Drawing.Size(60, 24);
            this.User.TabIndex = 13;
            this.User.Text = "User";
            this.User.UseVisualStyleBackColor = true;
            this.User.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Subreddit
            // 
            this.Subreddit.AutoSize = true;
            this.Subreddit.Location = new System.Drawing.Point(257, 103);
            this.Subreddit.Name = "Subreddit";
            this.Subreddit.Size = new System.Drawing.Size(96, 24);
            this.Subreddit.TabIndex = 14;
            this.Subreddit.Text = "Subreddit";
            this.Subreddit.UseVisualStyleBackColor = true;
            this.Subreddit.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Random
            // 
            this.Random.AutoSize = true;
            this.Random.Location = new System.Drawing.Point(359, 103);
            this.Random.Name = "Random";
            this.Random.Size = new System.Drawing.Size(87, 24);
            this.Random.TabIndex = 15;
            this.Random.Text = "Random";
            this.Random.UseVisualStyleBackColor = true;
            this.Random.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_2);
            // 
            // comboBox1
            // 
            this.comboBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Hot",
            "Top",
            "New",
            "Rising",
            "Controversial"});
            this.comboBox1.Location = new System.Drawing.Point(191, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "Choose Option";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Past Hour",
            "Past Day",
            "Past Week",
            "Past Month",
            "Past Year",
            "All"});
            this.comboBox2.Location = new System.Drawing.Point(191, 274);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(151, 28);
            this.comboBox2.TabIndex = 22;
            this.comboBox2.Text = "Choose Timeframe";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(191, 331);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(212, 56);
            this.trackBar1.SmallChange = 10;
            this.trackBar1.TabIndex = 100;
            this.trackBar1.TickFrequency = 10;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar_Scroll);
            // 
            // limitInput
            // 
            this.limitInput.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.limitInput.Location = new System.Drawing.Point(53, 331);
            this.limitInput.Name = "limitInput";
            this.limitInput.ReadOnly = true;
            this.limitInput.Size = new System.Drawing.Size(132, 27);
            this.limitInput.TabIndex = 101;
            this.limitInput.Text = "Download Limit";
            this.limitInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.limitInput.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox7.Location = new System.Drawing.Point(405, 334);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(94, 20);
            this.textBox7.TabIndex = 102;
            this.textBox7.Text = "0";
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged_1);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Location = new System.Drawing.Point(12, 515);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(132, 20);
            this.textBox2.TabIndex = 103;
            this.textBox2.Text = "Download Status";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // status
            // 
            this.status.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.status.Location = new System.Drawing.Point(150, 512);
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Size = new System.Drawing.Size(132, 27);
            this.status.TabIndex = 104;
            this.status.Text = "--";
            this.status.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // mediaType
            // 
            this.mediaType.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mediaType.FormattingEnabled = true;
            this.mediaType.Items.AddRange(new object[] {
            ".mp4",
            ".jpeg"});
            this.mediaType.Location = new System.Drawing.Point(348, 241);
            this.mediaType.Name = "mediaType";
            this.mediaType.Size = new System.Drawing.Size(151, 28);
            this.mediaType.TabIndex = 105;
            this.mediaType.Text = "Media Type";
            this.mediaType.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 554);
            this.Controls.Add(this.mediaType);
            this.Controls.Add(this.status);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.limitInput);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.Subreddit);
            this.Controls.Add(this.User);
            this.Controls.Add(this.linkTypeBox);
            this.Controls.Add(this.filterInput);
            this.Controls.Add(this.folderInput);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.typeInput);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStopProcess);
            this.Controls.Add(this.startSearchBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reddit Media Crawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startSearchBtn;
        private Button btnStopProcess;
        private TextBox textBox1;
        private TextBox typeInput;
        private TextBox textBox3;
        private TextBox folderInput;
        private TextBox filterInput;
        private TextBox linkTypeBox;
        private CheckBox User;
        private CheckBox Subreddit;
        private CheckBox Random;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TrackBar trackBar1;
        private TextBox limitInput;
        private TextBox textBox7;
        private TextBox textBox2;
        public TextBox status;
        private FileSystemWatcher fileSystemWatcher1;
        private ComboBox mediaType;
    }
}