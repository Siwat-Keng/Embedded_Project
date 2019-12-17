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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.carbutton1 = new SmartParking.Carbutton();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(70, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // carbutton1
            // 
            this.carbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(249)))), ((int)(((byte)(99)))));
            this.carbutton1.FlatAppearance.BorderSize = 0;
            this.carbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.carbutton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(94)))), ((int)(((byte)(49)))));
            this.carbutton1.Location = new System.Drawing.Point(4, 4);
            this.carbutton1.Name = "carbutton1";
            this.carbutton1.Size = new System.Drawing.Size(70, 70);
            this.carbutton1.TabIndex = 0;
            this.carbutton1.Text = "carbutton1";
            this.carbutton1.UseVisualStyleBackColor = false;
            // 
            // Park
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.carbutton1);
            this.Name = "Park";
            this.Size = new System.Drawing.Size(80, 116);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Carbutton carbutton1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}
