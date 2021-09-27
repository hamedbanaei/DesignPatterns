namespace DataFactory
{
	public static class CommandFactory
	{
		public static System.Data.IDbCommand GetCommand(System.Data.IDbConnection iDbConnection)
		{
			System.Data.IDbCommand oCommand = null;

			switch (ApplicationSettings.MyProvider)
			{
				case DataFactory.Providers.Sql:
					{
						oCommand =
							new System.Data.SqlClient.SqlCommand();
						break;
					}
				case DataFactory.Providers.Odbc:
					{
						oCommand =
							new System.Data.Odbc.OdbcCommand();
						break;
					}

				case DataFactory.Providers.Oracle:
					{
						oCommand =
							new System.Data.OracleClient.OracleCommand();
						break;
					}

				default:
					{
						oCommand =
							new System.Data.SqlClient.SqlCommand();
						break;
					}
			}

			oCommand.Connection =
				iDbConnection;

			return (oCommand);
		}
	}
}
