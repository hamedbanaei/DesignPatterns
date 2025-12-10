namespace Learn04;

public class Person : System.Object
{
	public Person()
	{
		Age = 0;
		FullName = string.Empty;
	}

	public Person(string fullName)
		: this()
	{
		FullName = fullName;
	}

	public Person(string fullName, int age)
		: this(fullName)
	{
		Age = age;
	}

	public int Age { get; set; }
	public string FullName { get; set; }

	/// <summary>
	/// With this, we don't need Copy Constructor anymore.
	/// This method doesn't implement any standard.
	/// </summary>
	/// <returns>A copy of current object.</returns>
	public Person Copy()
	{
		return ((Person)MemberwiseClone());
	}

	public void ShowInfo()
	{
		System.Console.WriteLine("\n\r**************************************************\n\r");
		System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
		System.Console.WriteLine("\n\r**************************************************\n\r");
	}
}
