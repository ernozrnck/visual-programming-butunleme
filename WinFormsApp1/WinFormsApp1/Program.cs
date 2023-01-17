namespace WinFormsApp1
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            string server = "127.0.0.1";
            int port = 3306;
            string uid = "root";
            string password = "secret";
            string database = "eczane";


            Root.DB = new DB(server, port, uid, password, database);
            Root.DB.Connect();
            
            Application.Run(new Form1());
        }
    }
}