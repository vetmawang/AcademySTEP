using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDoList
{
    class INSERT
    {
        MySQLDBConnection _connection;
        public INSERT(MySQLDBConnection connection)
        {
            _connection = connection;
        }
        public void Insert(ITable row)// отправляем запрос на добавление строки в таблицу 
        {
            List<string> columnNames = row.GetColumnNames();
            List<string> userData = row.GetData();
            string tableNames = row.GetTableName();
            string query = $"INSERT INTO {tableNames}(";
            int n = columnNames.Count;
            for (int i  = 0; i<n; i++)
            {
                
                query += columnNames[i];
                if (i != n - 1)
                    query += ",";
            }
            query += ") VALUES (";
            for(int i = 0; i < n; i ++)
            {
                if (userData[i] == "NULL" || userData[i] == "null" || userData[i] == "")
                {
                    query += "null";
                }
                else { query += $"'{userData[i]}'"; }
                if (i != n - 1)
                    query += ",";
            }
            query += ")";
            
            MySqlScript script = new MySqlScript(_connection.Connection, query);
            script.Execute();

        }
    }
}
