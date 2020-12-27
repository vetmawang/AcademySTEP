using System;
using System.Windows.Forms;

namespace ToDoList
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        MySQLConnectionString connStr;
        MySQLDBConnection mySQLDB;
        SELECT select;
   
        private void AcceptButton_Click(object sender, EventArgs e)// авторизация
        {
            select.Select(User.TableName, "user = '" + TBName.Text + "' and pass ='" + TBPass.Text + "'");
            if (select.TableToList(0) != null)
            {
                User loginUser = new User(select.TableToList(0));
                ToDo toDo = new ToDo(loginUser.Id);
                toDo.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Не верное имя пользователя или пароль");
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            connStr = new MySQLConnectionString("localhost", "root", "root", "newuser");
            mySQLDB = new MySQLDBConnection(connStr);
            select = new SELECT(mySQLDB);
        }

        private void signUP_Click(object sender, EventArgs e)
            //label при нажатии на который мы можем создать нового пользователя 
        {
            SignUP sign = new SignUP();
            sign.ShowDialog();
        }
    }
}
