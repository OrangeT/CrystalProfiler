using CrystalDecisions.Shared;

namespace CrystalProfiler
{
    public class CrystalConnectionString
    {
        public CrystalConnectionString(IConnectionInfo connection)
        {
            DatabaseName = connection.DatabaseName;
            ServerName = connection.ServerName;
            UserID = connection.UserID;
            Password = connection.Password;
            IntegratedSecurity = connection.IntegratedSecurity;
        }

        public string DatabaseName { get; set; }

        public string ServerName { get; set; }

        public string UserID { get; set; }

        public string Password { get; set; }

        public bool IntegratedSecurity { get; set; }

        public override string ToString()
        {
            return
                string.Format("DatabaseName: {0}, ServerName: {1}, UserID: {2}, " + 
                    "Password: {3}, IntegratedSecurity: {4}",
                    DatabaseName, ServerName, UserID, Password, IntegratedSecurity);
        }
    }
}