using MySql.Data.MySqlClient;


namespace SPID2Deconnecte
{
    internal class DBConnect
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "SPID2D";
            string username = "SPID2D";
            string password = "cUqUmGQdK2feyuw";

            // Connection String.
            string connString = "Server=" + host + ";Database=" + database
                + ";port=" + port + ";User Id=" + username + ";password=" + password;

            MySqlConnection conn = new MySqlConnection(connString);

            return conn;
        }
    }
}
