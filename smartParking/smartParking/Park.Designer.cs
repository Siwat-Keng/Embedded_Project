namespace SmartParking
{
    partial class Park
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
            this.carPark = new System.Windows.Forms.Button();
            this.beepCounter = new System.Windows.Forms.Timer(this.components);
            this.timeCounter = new SmartParking.TimeCounter();
            this.SuspendLayout();
            // 
            // carPark
            // 
            this.carPark.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.carPark.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.carPark.Location = new System.Drawing.Point(0, 0);
            this.carPark.Name = "carPark";
            this.carPark.Size = new System.Drawing.Size(105, 90);
            this.carPark.TabIndex = 1;
            this.carPark.Text = "Park";
            this.carPark.UseVisualStyleBackColor = true;
            this.carPark.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CarPark_MouseClick);
            // 
            // beepCounter
            // 
            this.beepCounter.Interval = 5000;
            this.beepCounter.Tick += new System.EventHandler(this.BeepCounter_Tick);
            // 
            // timeCounter
            // 
            this.timeCounter.AutoSize = true;
            this.timeCounter.Location = new System.Drawing.Point(-3, 0);
            this.timeCounter.Name = "timeCounter";
            this.timeCounter.Size = new System.Drawing.Size(108, 90);
            this.timeCounter.TabIndex = 0;
            // 
            // Park
            // 
            this.Controls.Add(this.carPark);
            this.Controls.Add(this.timeCounter);
            this.Name = "Park";
            this.Size = new System.Drawing.Size(105, 90);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TimeCounter timeCounter;
        private System.Windows.Forms.Button carPark;
        private System.Windows.Forms.Timer beepCounter;
    }
}
