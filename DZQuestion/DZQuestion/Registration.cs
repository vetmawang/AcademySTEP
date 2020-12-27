using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZQuestion
{
    public partial class Registration : Form
    {
        public Registration()
        {

            InitializeComponent();
            connectionDB connection = new connectionDB("127.0.0.1", "tester", "root", "root");
            trackBar1.Maximum = connection.QCount(trackBar1.Maximum);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength>5) {
            QuestionForm form = new QuestionForm(trackBar1.Value,textBox1.Text);
            this.Hide();
            form.Show();
            }
            else
            {
                MessageBox.Show("Пожалуйста введите имя студента, не менее 5 символов");
            }
          

        }
 
        private void Registration_Load(object sender, EventArgs e)
        {
       
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString(); 
        }
    }
}
