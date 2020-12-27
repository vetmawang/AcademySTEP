using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZQuestion
{
    public partial class QuestionForm : Form
    {
        int _QuestionCount;
        string _user = "";
        int CurrentQuestion;
        int goodAns;
        string question = "";
        connectionDB connection;
        public QuestionForm(int questionCcount, string userName)
        {
            InitializeComponent();
            _user = userName; 
            _QuestionCount = questionCcount;
            label3.Text = _QuestionCount.ToString();
            connection = new connectionDB("127.0.0.1", "tester", "root", "root");
            ShowInfo();
            
 
        }

        void ShowInfo()
        {
            if (CurrentQuestion < _QuestionCount   )
            {
                CurrentQuestion++;
                label2.Text = CurrentQuestion.ToString();
                question = connection.Question(question, CurrentQuestion);
                label4.Text = question;
                radioButton1.Text = connection.Answ(radioButton1.Text,CurrentQuestion,0);
                radioButton2.Text = connection.Answ(radioButton2.Text,CurrentQuestion,1);
                radioButton3.Text = connection.Answ(radioButton3.Text, CurrentQuestion,2);
                radioButton4.Text = connection.Answ(radioButton4.Text, CurrentQuestion,3);
            }
            else
            {//Решил не разбивать connectionDB на INSERT и SELECT , но очень хочется 
                this.Hide();
                MessageBox.Show($"правильных {goodAns} ответов из {_QuestionCount} ");
                Random random = new Random();
                int grade = random.Next(5);
                connection.uploadStat(goodAns, _user, _QuestionCount, grade);
                Application.Exit();
            }
        }
        void check()
        {
            int StudAns=0;
            if (radioButton1.Checked)
                StudAns = 1;
            if (radioButton2.Checked)
                StudAns = 2;
            if (radioButton3.Checked)
                StudAns = 3;
            if (radioButton4.Checked)
                StudAns = 4;

            if (connection.ChekAns(CurrentQuestion) == StudAns)
                goodAns++;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            check();
            ShowInfo();

        }

        private void QuestionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
