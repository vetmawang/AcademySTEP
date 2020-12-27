using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class NewTask : Form
    {
        public NewTask()
        {
            InitializeComponent();
        }
        string UID;
        public NewTask(string userId)
        {
             UID = userId;
            InitializeComponent();
        }
        MySQLConnectionString connStr;
        MySQLDBConnection mySQLDB;
        private void okBTN_Click(object sender, EventArgs e)
        {
            ToDoList newTask = new ToDoList(UID, NameTB.Text, NoteTB.Text,
                DeadLinePicker.Value.ToString("yyyy-MM-dd"), "не начато",
            PriorityUpDown.Value.ToString(), UrlTB.Text); // добавляем новый task в таблицу

              connStr = new MySQLConnectionString("localhost", "root", "root", "newuser");
              mySQLDB = new MySQLDBConnection(connStr);

            INSERT insertTask = new INSERT(mySQLDB);
            insertTask.Insert(newTask);
            Close();

        }
    }
}
