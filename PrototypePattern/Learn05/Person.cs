namespace Learn05;

public class Person : System.Object, System.ICloneable
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
	/// Benefit of implementing this method is its reuse in microsoft tools and libraries
	/// </summary>
	/// <returns>Creates an object exactly with object members value of the current object (Shallow Copy)</returns>
	public object Clone()
	{
		return (MemberwiseClone());
	}

	/// <summary>
	/// Implementing this method lets you copy object without need to explicit casting.
	/// </summary>
	/// <returns>Creates an object exactly with object members value of the current object (Shallow Copy)</returns>
	public Person Copy()
	{
		return ((Person)Clone());
	}

	public void ShowInfo()
	{
		System.Console.WriteLine("\n\r**************************************************\n\r");
		System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
		System.Console.WriteLine("\n\r**************************************************\n\r");
	}
}
