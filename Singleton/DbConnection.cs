namespace Design_Pattern.Singleton
{

    public class DbConnection
    {
        private static DbConnection _instance;
        private MySql _connection;
        private string _host;
        private string _username;
        private string _pass;
        private string _database;

        private DbConnection()
        {
            _connection = new MySql(_host, _username, _pass, _database);
        }
        public static DbConnection GetInstance() => _instance != null ? _instance : new DbConnection();
        private void init()
        {
            _host = "host";
            _username = "username";
            _pass = "pass";
            _database = "database";
        }
    }
}