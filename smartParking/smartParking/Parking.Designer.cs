namespace SmartParking
{
    partial class Parking
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
            this.slowBtn = new System.Windows.Forms.Button();
            this.spdBtn = new System.Windows.Forms.Button();
            this.rate = new System.Windows.Forms.Label();
            this.carInBtn = new System.Windows.Forms.Button();
            this.carParkBtn = new System.Windows.Forms.Button();
            this.carOutBtn = new System.Windows.Forms.Button();
            this.outNo = new System.Windows.Forms.TextBox();
            this.parkNo = new System.Windows.Forms.TextBox();
            this.connectStatus = new System.Windows.Forms.Label();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.park12 = new SmartParking.Park();
            this.park11 = new SmartParking.Park();
            this.park10 = new SmartParking.Park();
            this.park9 = new SmartParking.Park();
            this.park8 = new SmartParking.Park();
            this.park7 = new SmartParking.Park();
            this.park6 = new SmartParking.Park();
            this.park5 = new SmartParking.Park();
            this.park4 = new SmartParking.Park();
            this.park3 = new SmartParking.Park();
            this.park2 = new SmartParking.Park();
            this.park1 = new SmartParking.Park();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // slowBtn
            // 
            this.slowBtn.AutoSize = true;
            this.slowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.slowBtn.Location = new System.Drawing.Point(30, 108);
            this.slowBtn.Name = "slowBtn";
            this.slowBtn.Size = new System.Drawing.Size(75, 27);
            this.slowBtn.TabIndex = 14;
            this.slowBtn.Text = "Slow";
            this.slowBtn.UseVisualStyleBackColor = true;
            this.slowBtn.Click += new System.EventHandler(this.SlowBtn_Click);
            // 
            // spdBtn
            // 
            this.spdBtn.AutoSize = true;
            this.spdBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.spdBtn.Location = new System.Drawing.Point(176, 108);
            this.spdBtn.Name = "spdBtn";
            this.spdBtn.Size = new System.Drawing.Size(75, 27);
            this.spdBtn.TabIndex = 15;
            this.spdBtn.Text = "Speed";
            this.spdBtn.UseVisualStyleBackColor = true;
            this.spdBtn.Click += new System.EventHandler(this.SpdBtn_Click);
            // 
            // rate
            // 
            this.rate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rate.AutoSize = true;
            this.rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.rate.Location = new System.Drawing.Point(111, 113);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(28, 17);
            this.rate.TabIndex = 16;
            this.rate.Text = "1.0";
            this.rate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // carInBtn
            // 
            this.carInBtn.AutoSize = true;
            this.carInBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.carInBtn.Location = new System.Drawing.Point(548, 126);
            this.carInBtn.Name = "carInBtn";
            this.carInBtn.Size = new System.Drawing.Size(75, 36);
            this.carInBtn.TabIndex = 17;
            this.carInBtn.Text = "CarIn";
            this.carInBtn.UseVisualStyleBackColor = true;
            this.carInBtn.Click += new System.EventHandler(this.CarInBtn_Click);
            // 
            // carParkBtn
            // 
            this.carParkBtn.Location = new System.Drawing.Point(176, 54);
            this.carParkBtn.Name = "carParkBtn";
            this.carParkBtn.Size = new System.Drawing.Size(75, 23);
            this.carParkBtn.TabIndex = 18;
            this.carParkBtn.Text = "CarPark";
            this.carParkBtn.UseVisualStyleBackColor = true;
            this.carParkBtn.Click += new System.EventHandler(this.CarParkBtn_Click);
            // 
            // carOutBtn
            // 
            this.carOutBtn.AutoSize = true;
            this.carOutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.carOutBtn.Location = new System.Drawing.Point(631, 359);
            this.carOutBtn.Name = "carOutBtn";
            this.carOutBtn.Size = new System.Drawing.Size(92, 36);
            this.carOutBtn.TabIndex = 19;
            this.carOutBtn.Text = "CarOut";
            this.carOutBtn.UseVisualStyleBackColor = true;
            this.carOutBtn.Click += new System.EventHandler(this.CarOutBtn_Click);
            // 
            // outNo
            // 
            this.outNo.Location = new System.Drawing.Point(525, 371);
            this.outNo.Name = "outNo";
            this.outNo.Size = new System.Drawing.Size(100, 20);
            this.outNo.TabIndex = 20;
            // 
            // parkNo
            // 
            this.parkNo.Location = new System.Drawing.Point(70, 54);
            this.parkNo.Name = "parkNo";
            this.parkNo.Size = new System.Drawing.Size(100, 20);
            this.parkNo.TabIndex = 21;
            // 
            // connectStatus
            // 
            this.connectStatus.AutoSize = true;
            this.connectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.connectStatus.Location = new System.Drawing.Point(696, 12);
            this.connectStatus.Name = "connectStatus";
            this.connectStatus.Size = new System.Drawing.Size(86, 25);
            this.connectStatus.TabIndex = 23;
            this.connectStatus.Text = "Connect";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 83);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 30;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(176, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 31;
            this.button3.Text = "Send";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Message :";
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::SmartParking.Properties.Resources.down_arrow;
            this.pictureBox6.Location = new System.Drawing.Point(13, 220);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(64, 99);
            this.pictureBox6.TabIndex = 45;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::SmartParking.Properties.Resources.right_arrow;
            this.pictureBox5.Location = new System.Drawing.Point(416, 369);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 63);
            this.pictureBox5.TabIndex = 44;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::SmartParking.Properties.Resources.right_arrow;
            this.pictureBox4.Location = new System.Drawing.Point(146, 369);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 63);
            this.pictureBox4.TabIndex = 43;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::SmartParking.Properties.Resources.left_arrow2;
            this.pictureBox3.Location = new System.Drawing.Point(431, 229);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(64, 90);
            this.pictureBox3.TabIndex = 42;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SmartParking.Properties.Resources.left_arrow1;
            this.pictureBox2.Location = new System.Drawing.Point(146, 108);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 63);
            this.pictureBox2.TabIndex = 41;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SmartParking.Properties.Resources.left_arrow1;
            this.pictureBox1.Location = new System.Drawing.Point(416, 108);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 63);
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(445, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 20);
            this.label2.TabIndex = 46;
            this.label2.Text = "Car in";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label3.Location = new System.Drawing.Point(427, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 47;
            this.label3.Text = "Car out";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.parkNo);
            this.groupBox1.Controls.Add(this.carParkBtn);
            this.groupBox1.Controls.Add(this.slowBtn);
            this.groupBox1.Controls.Add(this.spdBtn);
            this.groupBox1.Controls.Add(this.rate);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.groupBox1.Location = new System.Drawing.Point(525, 413);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(278, 155);
            this.groupBox1.TabIndex = 48;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "simulate";
            // 
            // park12
            // 
            this.park12.Location = new System.Drawing.Point(305, 438);
            this.park12.Name = "park12";
            this.park12.Size = new System.Drawing.Size(105, 90);
            this.park12.TabIndex = 39;
            // 
            // park11
            // 
            this.park11.Location = new System.Drawing.Point(305, 273);
            this.park11.Name = "park11";
            this.park11.Size = new System.Drawing.Size(105, 90);
            this.park11.TabIndex = 38;
            // 
            // park10
            // 
            this.park10.Location = new System.Drawing.Point(194, 438);
            this.park10.Name = "park10";
            this.park10.Size = new System.Drawing.Size(105, 90);
            this.park10.TabIndex = 37;
            // 
            // park9
            // 
            this.park9.Location = new System.Drawing.Point(194, 273);
            this.park9.Name = "park9";
            this.park9.Size = new System.Drawing.Size(105, 90);
            this.park9.TabIndex = 36;
            // 
            // park8
            // 
            this.park8.Location = new System.Drawing.Point(83, 438);
            this.park8.Name = "park8";
            this.park8.Size = new System.Drawing.Size(105, 90);
            this.park8.TabIndex = 35;
            // 
            // park7
            // 
            this.park7.Location = new System.Drawing.Point(83, 273);
            this.park7.Name = "park7";
            this.park7.Size = new System.Drawing.Size(105, 90);
            this.park7.TabIndex = 34;
            // 
            // park6
            // 
            this.park6.Location = new System.Drawing.Point(83, 177);
            this.park6.Name = "park6";
            this.park6.Size = new System.Drawing.Size(105, 90);
            this.park6.TabIndex = 32;
            // 
            // park5
            // 
            this.park5.Location = new System.Drawing.Point(83, 12);
            this.park5.Name = "park5";
            this.park5.Size = new System.Drawing.Size(105, 90);
            this.park5.TabIndex = 28;
            // 
            // park4
            // 
            this.park4.Location = new System.Drawing.Point(194, 177);
            this.park4.Name = "park4";
            this.park4.Size = new System.Drawing.Size(105, 90);
            this.park4.TabIndex = 27;
            // 
            // park3
            // 
            this.park3.Location = new System.Drawing.Point(194, 12);
            this.park3.Name = "park3";
            this.park3.Size = new System.Drawing.Size(105, 90);
            this.park3.TabIndex = 26;
            // 
            // park2
            // 
            this.park2.Location = new System.Drawing.Point(305, 177);
            this.park2.Name = "park2";
            this.park2.Size = new System.Drawing.Size(105, 90);
            this.park2.TabIndex = 12;
            // 
            // park1
            // 
            this.park1.Location = new System.Drawing.Point(305, 12);
            this.park1.Name = "park1";
            this.park1.Size = new System.Drawing.Size(105, 90);
            this.park1.TabIndex = 11;
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 580);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.park12);
            this.Controls.Add(this.park11);
            this.Controls.Add(this.park10);
            this.Controls.Add(this.park9);
            this.Controls.Add(this.park8);
            this.Controls.Add(this.park7);
            this.Controls.Add(this.park6);
            this.Controls.Add(this.park5);
            this.Controls.Add(this.park4);
            this.Controls.Add(this.park3);
            this.Controls.Add(this.connectStatus);
            this.Controls.Add(this.outNo);
            this.Controls.Add(this.carOutBtn);
            this.Controls.Add(this.carInBtn);
            this.Controls.Add(this.park2);
            this.Controls.Add(this.park1);
            this.Name = "Parking";
            this.Text = "SmartParking";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Parking_FormClosed);
            this.Load += new System.EventHandler(this.Parking_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Parking_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Park park1;
        private Park park2;
        private System.Windows.Forms.Button slowBtn;
        private System.Windows.Forms.Button spdBtn;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Button carInBtn;
        private System.Windows.Forms.Button carParkBtn;
        private System.Windows.Forms.Button carOutBtn;
        private System.Windows.Forms.TextBox outNo;
        private System.Windows.Forms.TextBox parkNo;
        private System.Windows.Forms.Label connectStatus;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private Park park3;
        private Park park4;
        private Park park5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private Park park6;
        private System.Windows.Forms.Label label1;
        private Park park7;
        private Park park8;
        private Park park9;
        private Park park10;
        private Park park11;
        private Park park12;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

