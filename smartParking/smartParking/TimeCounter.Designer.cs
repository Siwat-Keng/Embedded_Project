namespace SmartParking
{
    partial class TimeCounter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.parkTime = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // parkTime
            // 
            this.parkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.parkTime.Location = new System.Drawing.Point(0, 0);
            this.parkTime.Name = "parkTime";
            this.parkTime.Size = new System.Drawing.Size(105, 47);
            this.parkTime.TabIndex = 0;
            this.parkTime.Text = "00:00:00";
            this.parkTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.parkTime.Click += new System.EventHandler(this.ParkTime_Click);
            // 
            // price
            // 
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.price.Location = new System.Drawing.Point(3, 47);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(102, 40);
            this.price.TabIndex = 1;
            this.price.Text = "Price : 0";
            this.price.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // TimeCounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.price);
            this.Controls.Add(this.parkTime);
            this.Name = "TimeCounter";
            this.Size = new System.Drawing.Size(105, 90);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label parkTime;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Timer timer;
    }
}
