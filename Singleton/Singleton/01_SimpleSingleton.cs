namespace Implementation01_SimpleSingleton
{
	// You may use this implementation of Singleton for single thread programs.
	// This implementation is the most simple one.
	// It's useable when you want to use it in classes that you can reach their sources.
	public sealed class Singleton
	{
		private static Singleton _instance = null;
		public static Singleton Instance
		{
			get
			{
				if (_instance == null)
				{
					_instance = new Singleton();
				}
				return (_instance);
			}
		}

		private Singleton()
		{
		}
	}
}
