namespace GenericSingleton
{
	public sealed class GenericSingleton<T> where T : class, new()
	{
		public static T Instance
		{
			get
			{
				return (SingletonCreator<T>.Instance);
			}
		}

		private GenericSingleton()
		{
		}

		private sealed class SingletonCreator<S> where S : class, new()
		{
			private static readonly S _instance = new S();
			public static S Instance
			{
				get
				{
					return (_instance);
				}
			}

			// Explicit static constructor to tell
			// C# compiler do not mark type as [BeforeFieldInit]
			static SingletonCreator()
			{
			}

			private SingletonCreator()
			{
			}
		}
	}
}
