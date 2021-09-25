namespace Implementation02_MultithreadSingletonWithLockObject
{
	public sealed class Singleton
	{
		private static readonly object _lockObject = new object();

		private static Singleton _instance = null;
		public static Singleton Instance
		{
			get
			{
				if (_instance == null)
				{
					lock (_lockObject)
					{
						// It's more safe than using one if statement before lock.
						// But we benefit static constructor and nested class ...
						// for the best result (as shown in following implementations).
						if (_instance == null)
						{
							_instance = new Singleton();
						}
					}
				}
				return (_instance);
			}
		}

		private Singleton()
		{
		}
	}
}
