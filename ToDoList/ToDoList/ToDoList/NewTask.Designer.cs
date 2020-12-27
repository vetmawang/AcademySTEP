namespace ToDoList
{
    partial class NewTask
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
            this.label1 = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NoteTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.DeadLinePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PriorityUpDown = new System.Windows.Forms.NumericUpDown();
            this.UrlTB = new System.Windows.Forms.TextBox();
            this.okBTN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PriorityUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(118, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(82, 25);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(138, 20);
            this.NameTB.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(118, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Подробности";
            // 
            // NoteTB
            // 
            this.NoteTB.Location = new System.Drawing.Point(82, 65);
            this.NoteTB.Multiline = true;
            this.NoteTB.Name = "NoteTB";
            this.NoteTB.Size = new System.Drawing.Size(138, 125);
            this.NoteTB.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Выполнить до:";
            // 
            // DeadLinePicker
            // 
            this.DeadLinePicker.Location = new System.Drawing.Point(82, 210);
            this.DeadLinePicker.Name = "DeadLinePicker";
            this.DeadLinePicker.Size = new System.Drawing.Size(138, 20);
            this.DeadLinePicker.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(115, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Приоритет";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(115, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дополнительно";
            // 
            // PriorityUpDown
            // 
            this.PriorityUpDown.Location = new System.Drawing.Point(82, 249);
            this.PriorityUpDown.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PriorityUpDown.Name = "PriorityUpDown";
            this.PriorityUpDown.Size = new System.Drawing.Size(138, 20);
            this.PriorityUpDown.TabIndex = 8;
            // 
            // UrlTB
            // 
            this.UrlTB.Location = new System.Drawing.Point(15, 289);
            this.UrlTB.Name = "UrlTB";
            this.UrlTB.Size = new System.Drawing.Size(289, 20);
            this.UrlTB.TabIndex = 9;
            // 
            // okBTN
            // 
            this.okBTN.Location = new System.Drawing.Point(121, 315);
            this.okBTN.Name = "okBTN";
            this.okBTN.Size = new System.Drawing.Size(75, 23);
            this.okBTN.TabIndex = 10;
            this.okBTN.Text = "Добавить";
            this.okBTN.UseVisualStyleBackColor = true;
            this.okBTN.Click += new System.EventHandler(this.okBTN_Click);
            // 
            // NewTask
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 396);
            this.Controls.Add(this.okBTN);
            this.Controls.Add(this.UrlTB);
            this.Controls.Add(this.PriorityUpDown);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DeadLinePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NoteTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTB);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(332, 435);
            this.MinimumSize = new System.Drawing.Size(332, 435);
            this.Name = "NewTask";
            this.Text = "Добавить задачу";
            ((System.ComponentModel.ISupportInitialize)(this.PriorityUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NoteTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DeadLinePicker;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown PriorityUpDown;
        private System.Windows.Forms.TextBox UrlTB;
        private System.Windows.Forms.Button okBTN;
    }
}