namespace Implementation03_LazyThreadSafeSingleton
{
	// It is fully lazy instantiation and thread-safe without using locks.
	public sealed class Singleton
	{
		public static Singleton Instance
		{
			get
			{
				return (SingletonCreator.Instance);
			}
		}

		private Singleton()
		{
		}

		private sealed class SingletonCreator
		{
			private static readonly Singleton _instance =
				new Singleton();

			public static Singleton Instance
			{
				get
				{
					return (_instance);
				}
			}

			static SingletonCreator()
			{
			}

			private SingletonCreator()
			{
			}
		}
	}
}
