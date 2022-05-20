namespace Robot
{
    partial class Form1
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
            System.Windows.Forms.DateTimePicker dateTimePicker1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ComboCamera = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.start_button = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.TestOutput = new System.Windows.Forms.Label();
            this.BtAuto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Saved = new System.Windows.Forms.Label();
            this.NotSaved = new System.Windows.Forms.Label();
            this.Victim = new System.Windows.Forms.TextBox();
            this.HelpVictim = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Status = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TestAlgorithm = new System.Windows.Forms.PictureBox();
            this.WebCam = new System.Windows.Forms.PictureBox();
            this.Tm = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.Message = new System.Windows.Forms.Label();
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestAlgorithm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebCam)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            dateTimePicker1.Location = new System.Drawing.Point(858, 24);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            dateTimePicker1.TabIndex = 14;
            // 
            // ComboCamera
            // 
            this.ComboCamera.FormattingEnabled = true;
            this.ComboCamera.Location = new System.Drawing.Point(136, 21);
            this.ComboCamera.Name = "ComboCamera";
            this.ComboCamera.Size = new System.Drawing.Size(386, 24);
            this.ComboCamera.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose Camera";
            // 
            // start_button
            // 
            this.start_button.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.start_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_button.Location = new System.Drawing.Point(544, 12);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(125, 33);
            this.start_button.TabIndex = 3;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = false;
            this.start_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Location = new System.Drawing.Point(3, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nở ra";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button2.Location = new System.Drawing.Point(3, 145);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 37);
            this.button2.TabIndex = 5;
            this.button2.Text = "Dừng lại";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // TestOutput
            // 
            this.TestOutput.AutoSize = true;
            this.TestOutput.Location = new System.Drawing.Point(712, 38);
            this.TestOutput.Name = "TestOutput";
            this.TestOutput.Size = new System.Drawing.Size(46, 17);
            this.TestOutput.TabIndex = 12;
            this.TestOutput.Text = "label2";
            this.TestOutput.Visible = false;
            // 
            // BtAuto
            // 
            this.BtAuto.BackColor = System.Drawing.Color.LightSkyBlue;
            this.BtAuto.Location = new System.Drawing.Point(3, 201);
            this.BtAuto.Name = "BtAuto";
            this.BtAuto.Size = new System.Drawing.Size(97, 37);
            this.BtAuto.TabIndex = 13;
            this.BtAuto.Text = "Tự động";
            this.BtAuto.UseVisualStyleBackColor = false;
            this.BtAuto.Click += new System.EventHandler(this.BtAuto_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Tổng số nạn nhân:";
            // 
            // Saved
            // 
            this.Saved.AutoSize = true;
            this.Saved.Location = new System.Drawing.Point(2, 65);
            this.Saved.Name = "Saved";
            this.Saved.Size = new System.Drawing.Size(143, 17);
            this.Saved.TabIndex = 16;
            this.Saved.Text = "Đã được cứu: 0 người";
            // 
            // NotSaved
            // 
            this.NotSaved.AutoSize = true;
            this.NotSaved.Location = new System.Drawing.Point(2, 98);
            this.NotSaved.Name = "NotSaved";
            this.NotSaved.Size = new System.Drawing.Size(106, 17);
            this.NotSaved.TabIndex = 17;
            this.NotSaved.Text = "Còn lại: 0 người";
            // 
            // Victim
            // 
            this.Victim.Location = new System.Drawing.Point(136, 30);
            this.Victim.Name = "Victim";
            this.Victim.Size = new System.Drawing.Size(109, 22);
            this.Victim.TabIndex = 18;
            // 
            // HelpVictim
            // 
            this.HelpVictim.BackColor = System.Drawing.Color.LightSkyBlue;
            this.HelpVictim.Location = new System.Drawing.Point(3, 33);
            this.HelpVictim.Name = "HelpVictim";
            this.HelpVictim.Size = new System.Drawing.Size(97, 37);
            this.HelpVictim.TabIndex = 19;
            this.HelpVictim.Text = "Truyền đồ";
            this.HelpVictim.UseVisualStyleBackColor = false;
            this.HelpVictim.Click += new System.EventHandler(this.HelpVictim_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.HelpVictim);
            this.groupBox1.Controls.Add(this.BtAuto);
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.pictureBox4);
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(711, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(347, 260);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Điều khiển thủ công";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Victim);
            this.groupBox2.Controls.Add(this.NotSaved);
            this.groupBox2.Controls.Add(this.Saved);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(710, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(348, 152);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin cuộc giải cứu";
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(21, 507);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(141, 17);
            this.Status.TabIndex = 22;
            this.Status.Text = "Trạng thái: Thủ công";
            this.Status.Click += new System.EventHandler(this.label3_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Robot.Properties.Resources.vippng_com_big_red_button_png_385418;
            this.pictureBox5.Location = new System.Drawing.Point(218, 132);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(50, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Robot.Properties.Resources.left;
            this.pictureBox4.Location = new System.Drawing.Point(162, 134);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(50, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 9;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::Robot.Properties.Resources.right;
            this.pictureBox3.Location = new System.Drawing.Point(218, 188);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(50, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Robot.Properties.Resources.down;
            this.pictureBox2.Location = new System.Drawing.Point(274, 132);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(50, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Robot.Properties.Resources.pngegg;
            this.pictureBox1.Location = new System.Drawing.Point(218, 76);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // TestAlgorithm
            // 
            this.TestAlgorithm.Location = new System.Drawing.Point(58, 65);
            this.TestAlgorithm.Name = "TestAlgorithm";
            this.TestAlgorithm.Size = new System.Drawing.Size(611, 417);
            this.TestAlgorithm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.TestAlgorithm.TabIndex = 11;
            this.TestAlgorithm.TabStop = false;
            // 
            // WebCam
            // 
            this.WebCam.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.WebCam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.WebCam.Location = new System.Drawing.Point(24, 51);
            this.WebCam.Name = "WebCam";
            this.WebCam.Size = new System.Drawing.Size(671, 444);
            this.WebCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.WebCam.TabIndex = 0;
            this.WebCam.TabStop = false;
            this.WebCam.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Tm
            // 
            this.Tm.Interval = 1000;
            this.Tm.Tick += new System.EventHandler(this.Tm_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 23;
            this.label3.Text = "label3";
            // 
            // Message
            // 
            this.Message.AutoSize = true;
            this.Message.Location = new System.Drawing.Point(201, 507);
            this.Message.Name = "Message";
            this.Message.Size = new System.Drawing.Size(73, 17);
            this.Message.TabIndex = 24;
            this.Message.Text = "Message: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 559);
            this.Controls.Add(this.Message);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(dateTimePicker1);
            this.Controls.Add(this.TestOutput);
            this.Controls.Add(this.TestAlgorithm);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ComboCamera);
            this.Controls.Add(this.WebCam);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TestAlgorithm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WebCam)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox WebCam;
        private System.Windows.Forms.ComboBox ComboCamera;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox TestAlgorithm;
        private System.Windows.Forms.Label TestOutput;
        private System.Windows.Forms.Button BtAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Saved;
        private System.Windows.Forms.Label NotSaved;
        private System.Windows.Forms.TextBox Victim;
        private System.Windows.Forms.Button HelpVictim;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.Timer Tm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Message;
    }
}

