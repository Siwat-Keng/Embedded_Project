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
            this.button1 = new System.Windows.Forms.Button();
            this.slowBtn = new System.Windows.Forms.Button();
            this.spdBtn = new System.Windows.Forms.Button();
            this.rate = new System.Windows.Forms.Label();
            this.carInBtn = new System.Windows.Forms.Button();
            this.carParkBtn = new System.Windows.Forms.Button();
            this.carOutBtn = new System.Windows.Forms.Button();
            this.outNo = new System.Windows.Forms.TextBox();
            this.parkNo = new System.Windows.Forms.TextBox();
            this.park2 = new SmartParking.Park();
            this.park1 = new SmartParking.Park();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 110);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // slowBtn
            // 
            this.slowBtn.Location = new System.Drawing.Point(545, 399);
            this.slowBtn.Name = "slowBtn";
            this.slowBtn.Size = new System.Drawing.Size(75, 23);
            this.slowBtn.TabIndex = 14;
            this.slowBtn.Text = "Slow";
            this.slowBtn.UseVisualStyleBackColor = true;
            this.slowBtn.Click += new System.EventHandler(this.SlowBtn_Click);
            // 
            // spdBtn
            // 
            this.spdBtn.Location = new System.Drawing.Point(667, 399);
            this.spdBtn.Name = "spdBtn";
            this.spdBtn.Size = new System.Drawing.Size(75, 23);
            this.spdBtn.TabIndex = 15;
            this.spdBtn.Text = "Speed";
            this.spdBtn.UseVisualStyleBackColor = true;
            this.spdBtn.Click += new System.EventHandler(this.SpdBtn_Click);
            // 
            // rate
            // 
            this.rate.AutoSize = true;
            this.rate.Location = new System.Drawing.Point(626, 404);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(22, 13);
            this.rate.TabIndex = 16;
            this.rate.Text = "1.0";
            // 
            // carInBtn
            // 
            this.carInBtn.Location = new System.Drawing.Point(142, 347);
            this.carInBtn.Name = "carInBtn";
            this.carInBtn.Size = new System.Drawing.Size(75, 23);
            this.carInBtn.TabIndex = 17;
            this.carInBtn.Text = "CarIn";
            this.carInBtn.UseVisualStyleBackColor = true;
            this.carInBtn.Click += new System.EventHandler(this.CarInBtn_Click);
            // 
            // carParkBtn
            // 
            this.carParkBtn.Location = new System.Drawing.Point(142, 376);
            this.carParkBtn.Name = "carParkBtn";
            this.carParkBtn.Size = new System.Drawing.Size(75, 23);
            this.carParkBtn.TabIndex = 18;
            this.carParkBtn.Text = "CarPark";
            this.carParkBtn.UseVisualStyleBackColor = true;
            this.carParkBtn.Click += new System.EventHandler(this.CarParkBtn_Click);
            // 
            // carOutBtn
            // 
            this.carOutBtn.Location = new System.Drawing.Point(142, 405);
            this.carOutBtn.Name = "carOutBtn";
            this.carOutBtn.Size = new System.Drawing.Size(75, 23);
            this.carOutBtn.TabIndex = 19;
            this.carOutBtn.Text = "CarOut";
            this.carOutBtn.UseVisualStyleBackColor = true;
            this.carOutBtn.Click += new System.EventHandler(this.CarOutBtn_Click);
            // 
            // outNo
            // 
            this.outNo.Location = new System.Drawing.Point(36, 407);
            this.outNo.Name = "outNo";
            this.outNo.Size = new System.Drawing.Size(100, 20);
            this.outNo.TabIndex = 20;
            // 
            // parkNo
            // 
            this.parkNo.Location = new System.Drawing.Point(36, 376);
            this.parkNo.Name = "parkNo";
            this.parkNo.Size = new System.Drawing.Size(100, 20);
            this.parkNo.TabIndex = 21;
            // 
            // park2
            // 
            this.park2.Location = new System.Drawing.Point(125, 13);
            this.park2.Name = "park2";
            this.park2.Size = new System.Drawing.Size(105, 90);
            this.park2.TabIndex = 12;
            // 
            // park1
            // 
            this.park1.Location = new System.Drawing.Point(13, 13);
            this.park1.Name = "park1";
            this.park1.Size = new System.Drawing.Size(105, 90);
            this.park1.TabIndex = 11;
            // 
            // Parking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.parkNo);
            this.Controls.Add(this.outNo);
            this.Controls.Add(this.carOutBtn);
            this.Controls.Add(this.carParkBtn);
            this.Controls.Add(this.carInBtn);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.spdBtn);
            this.Controls.Add(this.slowBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.park2);
            this.Controls.Add(this.park1);
            this.Name = "Parking";
            this.Text = "SmartParking";
            this.Load += new System.EventHandler(this.Parking_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Parking_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Park park1;
        private Park park2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button slowBtn;
        private System.Windows.Forms.Button spdBtn;
        private System.Windows.Forms.Label rate;
        private System.Windows.Forms.Button carInBtn;
        private System.Windows.Forms.Button carParkBtn;
        private System.Windows.Forms.Button carOutBtn;
        private System.Windows.Forms.TextBox outNo;
        private System.Windows.Forms.TextBox parkNo;
    }
}

