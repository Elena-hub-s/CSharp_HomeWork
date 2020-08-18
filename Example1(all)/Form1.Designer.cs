namespace WF_Udvoitel
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCommand1 = new System.Windows.Forms.Button();
            this.btnCommand2 = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblNumber = new System.Windows.Forms.Label();
            this.lblCountcmd = new System.Windows.Forms.Label();
            this.lblCountCommand = new System.Windows.Forms.Label();
            this.btnCommandPlay = new System.Windows.Forms.Button();
            this.lblGameText = new System.Windows.Forms.Label();
            this.lblCountNumberPlay = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCommand1
            // 
            this.btnCommand1.BackColor = System.Drawing.SystemColors.Control;
            this.btnCommand1.Location = new System.Drawing.Point(208, 27);
            this.btnCommand1.Name = "btnCommand1";
            this.btnCommand1.Size = new System.Drawing.Size(75, 23);
            this.btnCommand1.TabIndex = 0;
            this.btnCommand1.Text = "+ 1";
            this.btnCommand1.UseVisualStyleBackColor = false;
            this.btnCommand1.Click += new System.EventHandler(this.btnCommand1_Click);
            // 
            // btnCommand2
            // 
            this.btnCommand2.Location = new System.Drawing.Point(208, 70);
            this.btnCommand2.Name = "btnCommand2";
            this.btnCommand2.Size = new System.Drawing.Size(75, 23);
            this.btnCommand2.TabIndex = 0;
            this.btnCommand2.Text = "x 2";
            this.btnCommand2.UseVisualStyleBackColor = true;
            this.btnCommand2.Click += new System.EventHandler(this.btnCommand2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(208, 113);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Сброс";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblNumber
            // 
            this.lblNumber.AutoSize = true;
            this.lblNumber.Location = new System.Drawing.Point(55, 70);
            this.lblNumber.Name = "lblNumber";
            this.lblNumber.Size = new System.Drawing.Size(13, 13);
            this.lblNumber.TabIndex = 1;
            this.lblNumber.Text = "0";
            // 
            // lblCountcmd
            // 
            this.lblCountcmd.AutoSize = true;
            this.lblCountcmd.Location = new System.Drawing.Point(12, 139);
            this.lblCountcmd.Name = "lblCountcmd";
            this.lblCountcmd.Size = new System.Drawing.Size(93, 13);
            this.lblCountcmd.TabIndex = 2;
            this.lblCountcmd.Text = "Команд отдано - ";
            // 
            // lblCountCommand
            // 
            this.lblCountCommand.AutoSize = true;
            this.lblCountCommand.Location = new System.Drawing.Point(102, 139);
            this.lblCountCommand.Name = "lblCountCommand";
            this.lblCountCommand.Size = new System.Drawing.Size(13, 13);
            this.lblCountCommand.TabIndex = 3;
            this.lblCountCommand.Text = "0";
            // 
            // btnCommandPlay
            // 
            this.btnCommandPlay.Location = new System.Drawing.Point(208, 159);
            this.btnCommandPlay.Name = "btnCommandPlay";
            this.btnCommandPlay.Size = new System.Drawing.Size(75, 23);
            this.btnCommandPlay.TabIndex = 4;
            this.btnCommandPlay.Text = "Играть";
            this.btnCommandPlay.UseVisualStyleBackColor = true;
            this.btnCommandPlay.Click += new System.EventHandler(this.btnCommandPlay_Click);
            // 
            // lblGameText
            // 
            this.lblGameText.AutoSize = true;
            this.lblGameText.Location = new System.Drawing.Point(12, 169);
            this.lblGameText.Name = "lblGameText";
            this.lblGameText.Size = new System.Drawing.Size(92, 13);
            this.lblGameText.TabIndex = 5;
            this.lblGameText.Text = "Получите число -";
            this.lblGameText.Visible = false;
            // 
            // lblCountNumberPlay
            // 
            this.lblCountNumberPlay.AutoSize = true;
            this.lblCountNumberPlay.Location = new System.Drawing.Point(102, 169);
            this.lblCountNumberPlay.Name = "lblCountNumberPlay";
            this.lblCountNumberPlay.Size = new System.Drawing.Size(13, 13);
            this.lblCountNumberPlay.TabIndex = 6;
            this.lblCountNumberPlay.Text = "0";
            this.lblCountNumberPlay.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(208, 212);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Отменить";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Visible = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 247);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblCountNumberPlay);
            this.Controls.Add(this.lblGameText);
            this.Controls.Add(this.btnCommandPlay);
            this.Controls.Add(this.lblCountCommand);
            this.Controls.Add(this.lblCountcmd);
            this.Controls.Add(this.lblNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnCommand2);
            this.Controls.Add(this.btnCommand1);
            this.Name = "Form1";
            this.Text = "Удвоитель";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCommand1;
        private System.Windows.Forms.Button btnCommand2;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblNumber;
        private System.Windows.Forms.Label lblCountcmd;
        private System.Windows.Forms.Label lblCountCommand;
        private System.Windows.Forms.Button btnCommandPlay;
        private System.Windows.Forms.Label lblGameText;
        private System.Windows.Forms.Label lblCountNumberPlay;
        private System.Windows.Forms.Button btnBack;
    }
}

