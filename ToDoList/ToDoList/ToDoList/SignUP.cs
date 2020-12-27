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
    public partial class SignUP : Form
    {
        public SignUP()
        {
            InitializeComponent();
        }
        MySQLConnectionString connStr;
        MySQLDBConnection mySQLDB;
        INSERT insert;
        User newUser;
        SELECT select;

        private void AcceptButton_Click(object sender, EventArgs e)
            // проверяем существует ли данный пользователь и если нет ,
            // то добавляем нового пользователя 
        {
            select.Select(User.TableName, "user = '" + TBName.Text + "' and pass ='" + TBPass.Text + "'");
            if (select.TableToList(0) == null)
            {

                if (TBPass.Text == TBPass2.Text)
                {
                    newUser = new User(TBName.Text, TBPass.Text, System.DateTime.Today.ToString("yyyy-MM-dd"));
                    insert.Insert(newUser);
                    MessageBox.Show("Пользователь успешно создан!");
                    Close();
                }

                else
                { MessageBox.Show("Пароли не совпадают"); }
            }
            else {  MessageBox.Show("Имя пользователя занято"); }
         
        }

        private void SignUP_Load(object sender, EventArgs e)
            //подключаемся к базе данных 
        {
            connStr = new MySQLConnectionString("localhost", "root", "root", "newuser");
            mySQLDB = new MySQLDBConnection(connStr);
            insert = new INSERT(mySQLDB);
            select = new SELECT(mySQLDB);
        }
    }
}
