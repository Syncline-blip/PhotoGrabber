
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
            this.startBtn = new System.Windows.Forms.Button();
            this.btnStopProcess = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.User = new System.Windows.Forms.CheckBox();
            this.Subreddit = new System.Windows.Forms.CheckBox();
            this.Random = new System.Windows.Forms.CheckBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // startBtn
            // 
            this.startBtn.Location = new System.Drawing.Point(359, 291);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(158, 29);
            this.startBtn.TabIndex = 0;
            this.startBtn.Text = "Start Search";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnStopProcess
            // 
            this.btnStopProcess.Location = new System.Drawing.Point(359, 326);
            this.btnStopProcess.Name = "btnStopProcess";
            this.btnStopProcess.Size = new System.Drawing.Size(158, 29);
            this.btnStopProcess.TabIndex = 1;
            this.btnStopProcess.Text = "Stop Search";
            this.btnStopProcess.UseVisualStyleBackColor = true;
            this.btnStopProcess.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(191, 146);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(255, 27);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox2.Location = new System.Drawing.Point(53, 146);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(132, 27);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "Subreddit or User";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(191, 194);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(255, 27);
            this.textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox4.Location = new System.Drawing.Point(53, 194);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(132, 27);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Folder Name";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox5.Location = new System.Drawing.Point(53, 241);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(132, 27);
            this.textBox5.TabIndex = 7;
            this.textBox5.Text = "Filter By";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox6.Location = new System.Drawing.Point(53, 100);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(132, 27);
            this.textBox6.TabIndex = 12;
            this.textBox6.Text = "Reddit Link Type";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Past hour",
            "Past day",
            "Past week",
            "Past month",
            "Past year"});
            this.comboBox1.Location = new System.Drawing.Point(191, 240);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.Text = "...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(0, 370);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(564, 29);
            this.progressBar1.TabIndex = 22;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 396);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Random);
            this.Controls.Add(this.Subreddit);
            this.Controls.Add(this.User);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnStopProcess);
            this.Controls.Add(this.startBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Reddit Media Crawler";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button startBtn;
        private Button btnStopProcess;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private CheckBox User;
        private CheckBox Subreddit;
        private CheckBox Random;
        private ComboBox comboBox1;
        private ProgressBar progressBar1;
        private TextBox textBox7;
        private OpenFileDialog openFileDialog1;
    }
}