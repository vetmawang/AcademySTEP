using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZQuestion
{
     
    class connectionDB:IDisposable
    {
        MySqlConnection mySqlConnection;
        public connectionDB(string ServerName, string DataBaseName, string UID, string PWD)
        {
            mySqlConnection = new MySqlConnection();
            mySqlConnection.ConnectionString = $"Server={ServerName};Database={DataBaseName}; Uid={UID};Password={PWD};";
            mySqlConnection.Open();

        }
         public int QCount(int value)
        {
            string queru = "SELECT COUNT(*) as count FROM questions";
            MySqlCommand mySqlCommand = new MySqlCommand(queru, mySqlConnection);
            value = Convert.ToInt32(mySqlCommand.ExecuteScalar());
            return value;   

        }
        public string Question( string qustion, int count )
        {
            string queru = $"SELECT question FROM questions  WHERE id = {count}";
            MySqlCommand mySqlCommand = new MySqlCommand(queru, mySqlConnection);
            qustion = (mySqlCommand.ExecuteScalar()).ToString();
         


            return qustion;
        }
        public string Answ(string answ ,int count, int value)
        {
            string queru = $"SELECT a1,a2,a3,a4 FROM questions  WHERE id = {count}";
            MySqlDataAdapter adapter = new MySqlDataAdapter(queru, mySqlConnection);
            DataTable Table = new DataTable();
            adapter.Fill(Table);
            DataRow row = Table.Rows[0];
            answ = row.ItemArray[value].ToString();
            return answ;

        }
        public int ChekAns(int count )
        {
            string queru = $"SELECT number FROM questions WHERE id = {count}";
            MySqlCommand mySqlCommand = new MySqlCommand(queru, mySqlConnection);
            return Convert.ToInt32(mySqlCommand.ExecuteScalar());
        
        }
       public void  uploadStat(int goodAns , string userName , int countQ, int grade)
        {
            
            string queru = $"INSERT INTO `students`( `name`, `countA`, `countQ`, `grade`) VALUES ('{userName}',{goodAns},{countQ},{grade})";
            MySqlCommand mySqlCommand = new MySqlCommand(queru, mySqlConnection);
            mySqlCommand.ExecuteNonQuery();
        }
        public void Dispose()
        {
            mySqlConnection.Close();

        }


    }
}
