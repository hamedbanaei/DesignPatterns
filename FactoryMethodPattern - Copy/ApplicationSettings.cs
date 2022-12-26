namespace FactoryMethodPattern
{
	class ApplicationSettings : System.Object
	{
		private static string ProviderKeyName
		{
			get
			{
				return ("Provider");
			}
		}

		private static Providers? _myProvider;
		public static Providers MyProvider
		{
			get
			{
				if (_myProvider.HasValue == false)
				{
					if (string.IsNullOrEmpty(System.Configuration.ConfigurationManager.AppSettings[ProviderKeyName]))
					{
						_myProvider = Providers.Sql;
					}
					else
					{
						string strProvider =
							System.Configuration.ConfigurationManager.AppSettings[ProviderKeyName].Trim().ToUpper();

						switch (strProvider)
						{
							case "SQL":
								{
									_myProvider = Providers.Sql;
									break;
								}

							case "ODBC":
								{
									_myProvider = Providers.Odbc;
									break;
								}

							case "ORACLE":
								{
									_myProvider = Providers.Oracle;
									break;
								}

							default:
								{
									_myProvider = Providers.Sql;
									break;
								}
						}
					}
				}

				return (_myProvider.Value);
			}
		}


		private static string _myConnectionString;
		public static string MyConnectionString
		{
			get
			{
				if (_myConnectionString == null)
				{
					_myConnectionString =
						System.Configuration.ConfigurationManager.AppSettings["ConnectionString"];
				}
				return (_myConnectionString);
			}
		}

	}
}
