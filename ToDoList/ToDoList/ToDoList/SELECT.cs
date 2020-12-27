using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;

namespace ToDoList
{
    class SELECT
    {
        MySQLDBConnection _connection;
        public DataTable Table { get; private set; }
        public SELECT(MySQLDBConnection connection)
        {
            _connection = connection;
            Table = new DataTable();
        }
        public void Select(string TableName, string options = "1")
            //запрашиваем таблицу и делаем ее читабельной для C#
        {
            string query = "SELECT * from " + TableName + " where " + options;
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, _connection.Connection);
            Table.Clear();
            dataAdapter.Fill(Table);
        }
        public void Select(string query)//перегрузка select
        {
            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, _connection.Connection);
            Table.Clear();
            dataAdapter.Fill(Table);
        }
        public List<string> TableToList(int index)//переделываем таблицу в строку
        {
            if (index < Table.Rows.Count)
            {
                List<string> result = new List<string>();
                DataRow row = Table.Rows[index];

                int len = row.ItemArray.Length;
                for (int i = 0; i < len; i++)
                    result.Add(row.ItemArray[i].ToString());
                return result;
            }
            return null;
        }
    }
}
