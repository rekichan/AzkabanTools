using MySql.Data.MySqlClient;

namespace AzkabanTools
{
    class cls_Database
    {
        public static string dbConfigPath=System.Windows.Forms.Application.StartupPath+@"\Parameter\config.ini";
        public static MySqlConnection conn;
        public static bool linkStatus;
        public static bool linking;

        public static cls_WRIni config;
        public static string hostName;
        public static string port;
        public static string userName;
        public static string password;
    }
}
