using System;
using System.Net;
using System.Security.Policy;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class ToDo : Form
    {
        public ToDo()
        {
            InitializeComponent();
        }

        string userId;
        string url;
        string id;
        int ColumnSize;
        public ToDo(string userID)
        {
            this.userId = userID;
            InitializeComponent();
        }
        MySQLDBConnection mySQLDB;
          
        private void RefreshDataGrid(string query)//обновление таблицы
        {
            SELECT select = new SELECT(mySQLDB);
            select.Select(query); // есть выбоор перегрузки
            MyTaskDG.DataSource = select.Table;
           
        }
        private void ToDo_FormClosed(object sender, FormClosedEventArgs e)//закрываем приложение 
        {
            Application.Exit();
        }

        private void NewTaskBTN_Click(object sender, System.EventArgs e)// создаем новый таск
        {
            NewTask newTask = new NewTask(userId);
            newTask.ShowDialog();
            RefreshDataGrid( $"SELECT id, name, status, priority, deadline, url FROM todolist WHERE userId ={userId}"); 
        }

        private void ToDo_Load(object sender, System.EventArgs e)
            // отправляем запрос на подкключение к базе данных 
        {
            MySQLConnectionString connStr = new MySQLConnectionString("localhost", "root", "root", "newuser");
            mySQLDB = new MySQLDBConnection(connStr);
            RefreshDataGrid(  $"SELECT id, name, status, priority, deadline, url FROM todolist WHERE userId ={userId}");
           
        }

        private void MyTaskDG_CellClick(object sender, DataGridViewCellEventArgs e)
            //добавляем на панель инструментов информауию доступную для изменения 
        {
            int index = e.RowIndex;
             
            if (index >= 0) {   
                id = MyTaskDG[0, index].Value.ToString();
                SELECT select = new SELECT(mySQLDB);
                select.Select($"SELECT note, status, url FROM todolist WHERE id={id}");
                noteRT.Text = select.Table.Rows[0].ItemArray[0].ToString();
                statusCB.Text = select.Table.Rows[0].ItemArray[1].ToString();
               urlTB.Text= url = select.Table.Rows[0].ItemArray[2].ToString();
            }
         

        }

        private void downloadBTN_Click(object sender, System.EventArgs e)//установка дополнительных материалов
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                Downloaders download = new Downloaders(url, folderBrowserDialog.SelectedPath);
        
                if (download.DownloadFile())
                {
                    MessageBox.Show("Установка завершена!");
                }
                else
                {
                    MessageBox.Show("Ошибка");

                }
            }
        }

        private void saveBTN_Click(object sender, EventArgs e)//сохраняем изменения и обновляем таблицу
        {
            UPDATEToDoList update = new UPDATEToDoList(mySQLDB);
            update.update(id,noteRT.Text,statusCB.Text);
            RefreshDataGrid($"SELECT id, name, status, priority, deadline, url FROM todolist WHERE userId ={userId}");
        }
        private void ResizeGrid(int ColumnSize)//адаптируем  размер таблицы 
        {
             int  n = MyTaskDG.RowCount;
             int y = MyTaskDG.ColumnCount;
            if ((n != 0)&&(y != 0))
            {
                ColumnSize = (ColumnSize - statusPanel.Width )/y ;
              
                for (int i = 0; i < y; i++)
                {
                    MyTaskDG.Columns[i].Width = ColumnSize-1;
              
                }
            }
        }

        private void ToDo_Resize(object sender, EventArgs e)//отправляем данные о текущем размере таблицы
        {
           ColumnSize  =  this.Width;

          
            ResizeGrid(ColumnSize);
        }
    }
}
