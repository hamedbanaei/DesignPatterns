namespace DataFactory
{
	class Program
	{
		static void Main(string[] args)
		{
			// Now it's comming to use it ...

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
