namespace FactoryMethodPattern
{
	public static class ConnectionFactory
	{
		public static System.Data.IDbConnection GetConnection()
		{
			

			System.Data.IDbConnection oConnection = null;

            switch (ApplicationSettings.MyProvider)
            {
                case Providers.Sql:
                    {
                        oConnection =
                            new System.Data.SqlClient.SqlConnection(ApplicationSettings.MyConnectionString);
                        break;
                    }
                case Providers.Odbc:
                    {
                        oConnection =
                            new System.Data.Odbc.OdbcConnection(ApplicationSettings.MyConnectionString);
                        break;
                    }

                case Providers.Oracle:
                    {
                        oConnection =
                            new System.Data.OracleClient.OracleConnection(ApplicationSettings.MyConnectionString);
                        break;
                    }

                default:
                    {
                        oConnection =
                            new System.Data.SqlClient.SqlConnection(ApplicationSettings.MyConnectionString);
                        break;
                    }
            }

            return (oConnection);
		}
	}
}
