namespace Example1
{
    partial class Form2
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
            this.txtBoxForm2 = new System.Windows.Forms.TextBox();
            this.btnfrm2Go = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBoxForm2
            // 
            this.txtBoxForm2.Location = new System.Drawing.Point(12, 12);
            this.txtBoxForm2.Name = "txtBoxForm2";
            this.txtBoxForm2.Size = new System.Drawing.Size(100, 20);
            this.txtBoxForm2.TabIndex = 1;
            // 
            // btnfrm2Go
            // 
            this.btnfrm2Go.Location = new System.Drawing.Point(125, 10);
            this.btnfrm2Go.Name = "btnfrm2Go";
            this.btnfrm2Go.Size = new System.Drawing.Size(75, 23);
            this.btnfrm2Go.TabIndex = 2;
            this.btnfrm2Go.Text = "Ввести";
            this.btnfrm2Go.UseVisualStyleBackColor = true;
            this.btnfrm2Go.Click += new System.EventHandler(this.btnfrm2Go_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 41);
            this.Controls.Add(this.btnfrm2Go);
            this.Controls.Add(this.txtBoxForm2);
            this.Name = "Form2";
            this.Text = "Введите число";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxForm2;
        private System.Windows.Forms.Button btnfrm2Go;
    }
}