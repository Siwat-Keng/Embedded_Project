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
            this.Time = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.carbutton1 = new SmartParking.Carbutton();
            this.park3 = new SmartParking.Park();
            this.park2 = new SmartParking.Park();
            this.park1 = new SmartParking.Park();
            this.carbutton2 = new SmartParking.Carbutton();
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
            // Time
            // 
            this.Time.AutoSize = true;
            this.Time.Location = new System.Drawing.Point(306, 308);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(49, 13);
            this.Time.TabIndex = 12;
            this.Time.Text = "00:00:00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 390);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(218, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(260, 389);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(489, 188);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(234, 145);
            this.textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(489, 154);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 17;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(612, 151);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 18;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // carbutton1
            // 
            this.carbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(249)))), ((int)(((byte)(99)))));
            this.carbutton1.FlatAppearance.BorderSize = 0;
            this.carbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carbutton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.carbutton1.Location = new System.Drawing.Point(48, 172);
            this.carbutton1.Name = "carbutton1";
            this.carbutton1.Size = new System.Drawing.Size(70, 70);
            this.carbutton1.TabIndex = 22;
            this.carbutton1.Text = "carbutton1";
            this.carbutton1.UseVisualStyleBackColor = false;
            this.carbutton1.Click += new System.EventHandler(this.Carbutton1_Click);
            // 
            // park3
            // 
            this.park3.Location = new System.Drawing.Point(309, 13);
            this.park3.Name = "park3";
            this.park3.Size = new System.Drawing.Size(113, 167);
            this.park3.TabIndex = 21;
            this.park3.Tag = "";
            // 
            // park2
            // 
            this.park2.Location = new System.Drawing.Point(179, 13);
            this.park2.Name = "park2";
            this.park2.Size = new System.Drawing.Size(213, 164);
            this.park2.TabIndex = 20;
            // 
            // park1
            // 
            this.park1.Location = new System.Drawing.Point(370, 208);
            this.park1.Name = "park1";
            this.park1.Size = new System.Drawing.Size(113, 167);
            this.park1.TabIndex = 23;
            // 
            // carbutton2
            // 
            this.carbutton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(249)))), ((int)(((byte)(99)))));
            this.carbutton2.FlatAppearance.BorderSize = 0;
            this.carbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carbutton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.carbutton2.Location = new System.Drawing.Point(502, 43);
            this.carbutton2.Name = "carbutton2";
            this.carbutton2.Size = new System.Drawing.Size(240, 76);
            this.carbutton2.TabIndex = 24;
            this.carbutton2.Text = "carbutton2";
            this.carbutton2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.carbutton2);
            this.Controls.Add(this.park1);
            this.Controls.Add(this.carbutton1);
            this.Controls.Add(this.park3);
            this.Controls.Add(this.park2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Time);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label Time;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button4;
        private Park park2;
        private Park park3;
        private Carbutton carbutton1;
        private Park park1;
        private Carbutton carbutton2;
    }
}

