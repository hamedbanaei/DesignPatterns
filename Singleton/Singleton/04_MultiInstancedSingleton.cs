namespace Implementation04_MultiInstancedSingleton
{
	// The Multi-Instanced Singleton
	// We have some printers (or any other concept) for managing...
	public sealed class PrintManager
	{
		private static readonly System.Collections.Generic.Dictionary<string, PrintManager>
			_instances = new System.Collections.Generic.Dictionary<string, PrintManager>();

		public static PrintManager GetInstance(string printerName)
		{
			lock (_instances)
			{
				if (_instances.ContainsKey(printerName) == false)
				{
					_instances.Add(printerName, new PrintManager());
				}
			}
			return (_instances[printerName]);
		}

		static PrintManager()
		{
		}

		private PrintManager()
		{
		}
	}
}
