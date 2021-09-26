namespace Implementation05_MultiInstancedSingletonPerThread
{
	// The Multi-Instanced Singleton
	// We want each thread has it's own connection...
	public sealed class ConnectionManager
	{
		// I prefer to use IDbConnection Interface instead of SqlConnection in the dictionary declaration.
		// It's really useful particularly when immigration to another database.
		// When it comes to DataBase immigration, the only line that needs change is line 21!
		private static readonly System.Collections.Generic.Dictionary<System.Threading.Thread, System.Data.IDbConnection>
			_instances = new System.Collections.Generic.Dictionary<System.Threading.Thread, System.Data.IDbConnection>();

		public static System.Data.IDbConnection Instance
		{
			get
			{
				lock (_instances)
				{
					if (_instances.ContainsKey(System.Threading.Thread.CurrentThread) == false)
					{
						_instances.Add(System.Threading.Thread.CurrentThread, new System.Data.SqlClient.SqlConnection("Connection Staring that would be better to read from config file"));
					}
				}

				return (_instances[System.Threading.Thread.CurrentThread]);
			}
		}

		static ConnectionManager()
		{
		}

		private ConnectionManager()
		{
		}
	}
}
