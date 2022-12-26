namespace FactoryMethodPattern
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
			
			System.Data.IDbConnection oConnection = null;
			System.Data.IDbCommand oCommand = null;

			try
			{
				oConnection =
					ConnectionFactory.GetConnection();

				oCommand =
					CommandFactory.GetCommand(oConnection);

				// Now use oConnection and oCommand and remember:
				// To immigrate to another DBMS
				// Simply use pure T-Sql and
				// Change Provider key in config!
			}
			catch (System.Exception ex)
			{
				System.Console.WriteLine(ex.Message);
			}
		}
    }
}