namespace ToDoList
{
    partial class ToDo
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
            this.NewTaskBTN = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MyTaskDG = new System.Windows.Forms.DataGridView();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.saveBTN = new System.Windows.Forms.Button();
            this.downloadBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.statusCB = new System.Windows.Forms.ComboBox();
            this.noteRT = new System.Windows.Forms.RichTextBox();
            this.urlTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTaskDG)).BeginInit();
            this.statusPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NewTaskBTN
            // 
            this.NewTaskBTN.Location = new System.Drawing.Point(3, 6);
            this.NewTaskBTN.Name = "NewTaskBTN";
            this.NewTaskBTN.Size = new System.Drawing.Size(75, 22);
            this.NewTaskBTN.TabIndex = 0;
            this.NewTaskBTN.Text = "button1";
            this.NewTaskBTN.UseVisualStyleBackColor = true;
            this.NewTaskBTN.Click += new System.EventHandler(this.NewTaskBTN_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.NewTaskBTN);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 34);
            this.panel1.TabIndex = 1;
            // 
            // MyTaskDG
            // 
            this.MyTaskDG.AllowUserToAddRows = false;
            this.MyTaskDG.AllowUserToDeleteRows = false;
            this.MyTaskDG.AllowUserToResizeRows = false;
            this.MyTaskDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTaskDG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MyTaskDG.Location = new System.Drawing.Point(0, 34);
            this.MyTaskDG.MultiSelect = false;
            this.MyTaskDG.Name = "MyTaskDG";
            this.MyTaskDG.ReadOnly = true;
            this.MyTaskDG.RowHeadersVisible = false;
            this.MyTaskDG.Size = new System.Drawing.Size(798, 482);
            this.MyTaskDG.TabIndex = 2;
            this.MyTaskDG.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.MyTaskDG_CellClick);
            // 
            // statusPanel
            // 
            this.statusPanel.Controls.Add(this.urlTB);
            this.statusPanel.Controls.Add(this.saveBTN);
            this.statusPanel.Controls.Add(this.downloadBTN);
            this.statusPanel.Controls.Add(this.label1);
            this.statusPanel.Controls.Add(this.statusCB);
            this.statusPanel.Controls.Add(this.noteRT);
            this.statusPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.statusPanel.Location = new System.Drawing.Point(598, 34);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(200, 482);
            this.statusPanel.TabIndex = 3;
            // 
            // saveBTN
            // 
            this.saveBTN.Location = new System.Drawing.Point(3, 253);
            this.saveBTN.Name = "saveBTN";
            this.saveBTN.Size = new System.Drawing.Size(179, 30);
            this.saveBTN.TabIndex = 4;
            this.saveBTN.Text = "Сохранить изменения";
            this.saveBTN.UseVisualStyleBackColor = true;
            this.saveBTN.Click += new System.EventHandler(this.saveBTN_Click);
            // 
            // downloadBTN
            // 
            this.downloadBTN.Location = new System.Drawing.Point(6, 212);
            this.downloadBTN.Name = "downloadBTN";
            this.downloadBTN.Size = new System.Drawing.Size(121, 22);
            this.downloadBTN.TabIndex = 3;
            this.downloadBTN.Text = "Скачать доп.материал";
            this.downloadBTN.UseVisualStyleBackColor = true;
            this.downloadBTN.Click += new System.EventHandler(this.downloadBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус:";
            // 
            // statusCB
            // 
            this.statusCB.FormattingEnabled = true;
            this.statusCB.Items.AddRange(new object[] {
            "В разработке",
            "Завершено",
            "Не начато",
            "Тестируется",
            "Отменено"});
            this.statusCB.Location = new System.Drawing.Point(6, 159);
            this.statusCB.Name = "statusCB";
            this.statusCB.Size = new System.Drawing.Size(121, 21);
            this.statusCB.TabIndex = 1;
            // 
            // noteRT
            // 
            this.noteRT.Location = new System.Drawing.Point(3, 3);
            this.noteRT.Name = "noteRT";
            this.noteRT.Size = new System.Drawing.Size(179, 137);
            this.noteRT.TabIndex = 0;
            this.noteRT.Text = "";
            // 
            // urlTB
            // 
            this.urlTB.Location = new System.Drawing.Point(6, 186);
            this.urlTB.Name = "urlTB";
            this.urlTB.Size = new System.Drawing.Size(121, 20);
            this.urlTB.TabIndex = 5;
            // 
            // ToDo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 516);
            this.Controls.Add(this.statusPanel);
            this.Controls.Add(this.MyTaskDG);
            this.Controls.Add(this.panel1);
            this.Name = "ToDo";
            this.Text = "ToDo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ToDo_FormClosed);
            this.Load += new System.EventHandler(this.ToDo_Load);
            this.Resize += new System.EventHandler(this.ToDo_Resize);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MyTaskDG)).EndInit();
            this.statusPanel.ResumeLayout(false);
            this.statusPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NewTaskBTN;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView MyTaskDG;
        private System.Windows.Forms.Panel statusPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox statusCB;
        private System.Windows.Forms.RichTextBox noteRT;
        private System.Windows.Forms.Button saveBTN;
        private System.Windows.Forms.Button downloadBTN;
        private System.Windows.Forms.TextBox urlTB;
    }
}