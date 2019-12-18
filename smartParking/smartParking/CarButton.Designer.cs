namespace SmartParking
{
    partial class Carbutton
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
            this.car = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // car
            // 
            this.car.BackColor = System.Drawing.Color.Lime;
            this.car.Location = new System.Drawing.Point(0, 0);
            this.car.Name = "car";
            this.car.Size = new System.Drawing.Size(75, 23);
            this.car.TabIndex = 0;
            this.car.Text = " ";
            this.car.UseVisualStyleBackColor = false;
            this.car.Click += new System.EventHandler(this.Car_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button car;
        private System.Windows.Forms.Label label1;
    }
}
