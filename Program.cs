namespace WFA240207
{
    internal static class Program
    {
        internal static string connectionString =
            @"SERVER=(localdb)\MSSQLLocalDB;DATABASE=jadijasok;";

        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new FrmMain());
        }
    }
}