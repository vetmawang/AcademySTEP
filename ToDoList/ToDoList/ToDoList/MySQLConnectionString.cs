namespace ToDoList
{
    class MySQLConnectionString : IConnectionString
    {
        string _server;
        string _user;
        string _pass;
        string _port;
        string _dataBase;

        public MySQLConnectionString(string Server, string User, string Password,
            string DBName, string Port)
        {
            _server = Server;
            _user = User;
            _pass = Password;
            _port = Port;
            _dataBase = DBName;
        }

        public MySQLConnectionString(string Server, string User, string Password,
          string DBName)
        {
            _server = Server;
            _user = User;
            _pass = Password;
            _port = "3306";
            _dataBase = DBName;
        }

        public string ConnectionString() // возвращаем строку с данными сервера к которому конектимся
        {
            string connStr =
                    "Server=" + _server + ";" +
                    "Database=" + _dataBase + ";" +
                    "Uid=" + _user + ";" +
                    "Pwd=" + _pass + ";" +
                    "Port =" + _port + ";"; 
            return connStr;
        }
    }
}
