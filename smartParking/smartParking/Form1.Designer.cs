namespace SmartParking
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.park4 = new SmartParking.Park();
            this.park3 = new SmartParking.Park();
            this.park2 = new SmartParking.Park();
            this.park1 = new SmartParking.Park();
            this.Time = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "จอง";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(48, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "จอด";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(48, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 11;
            this.button3.Text = "ว่าง";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // park4
            // 
            this.park4.Location = new System.Drawing.Point(43, 179);
            this.park4.Name = "park4";
            this.park4.Size = new System.Drawing.Size(80, 116);
            this.park4.TabIndex = 10;
            // 
            // park3
            // 
            this.park3.Location = new System.Drawing.Point(216, 66);
            this.park3.Name = "park3";
            this.park3.Size = new System.Drawing.Size(80, 116);
            this.park3.TabIndex = 9;
            // 
            // park2
            // 
            this.park2.Location = new System.Drawing.Point(129, 66);
            this.park2.Name = "park2";
            this.park2.Size = new System.Drawing.Size(80, 116);
            this.park2.TabIndex = 6;
            // 
            // park1
            // 
            this.park1.Location = new System.Drawing.Point(43, 66);
            this.park1.Name = "park1";
            this.park1.Size = new System.Drawing.Size(80, 116);
            this.park1.TabIndex = 5;
            // 
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(149, 323);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(49, 13);
            this.Time.TabIndex = 12;
            this.Time.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.park4);
            this.Controls.Add(this.park3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.park2);
            this.Controls.Add(this.park1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Park park1;
        private Park park2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private Park park3;
        private Park park4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Time;
    }
}

