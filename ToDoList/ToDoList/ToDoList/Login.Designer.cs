﻿namespace ToDoList
{
    partial class Login
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
            this.TBName = new System.Windows.Forms.TextBox();
            this.TBPass = new System.Windows.Forms.TextBox();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.signUP = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(39, 71);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 0;
            // 
            // TBPass
            // 
            this.TBPass.Location = new System.Drawing.Point(39, 118);
            this.TBPass.Name = "TBPass";
            this.TBPass.PasswordChar = '*';
            this.TBPass.Size = new System.Drawing.Size(100, 20);
            this.TBPass.TabIndex = 1;
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(39, 160);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(100, 23);
            this.AcceptButton.TabIndex = 2;
            this.AcceptButton.Text = "Войти";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // signUP
            // 
            this.signUP.AutoSize = true;
            this.signUP.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signUP.Location = new System.Drawing.Point(53, 186);
            this.signUP.Name = "signUP";
            this.signUP.Size = new System.Drawing.Size(72, 13);
            this.signUP.TabIndex = 3;
            this.signUP.Text = "Регистрация";
            this.signUP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.signUP.UseWaitCursor = true;
            this.signUP.Click += new System.EventHandler(this.signUP_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.AcceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(185, 303);
            this.Controls.Add(this.signUP);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.TBPass);
            this.Controls.Add(this.TBName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Login";
            this.Text = "Вход";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.TextBox TBPass;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Label signUP;
    }
}

