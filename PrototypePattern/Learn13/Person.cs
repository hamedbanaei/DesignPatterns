namespace Learn13;

[System.Serializable]
public class Person : System.Object
{
	/// <summary>
	/// Despite Binary serialization, XML serialization needs default constructor.
	/// </summary>
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

	public void ShowInfo()
	{
		System.Console.WriteLine($"I'm {FullName} and {Age} years old.");
	}
}
