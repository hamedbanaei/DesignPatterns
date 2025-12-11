namespace Learn07;

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

	public void ShowInfo()
	{
		System.Console.WriteLine($"I'm {FullName} and {Age} years old.");
	}

	public object Clone()
	{
		return (MemberwiseClone());
	}

	public Person Copy()
	{
		return ((Person)Clone());
	}
}
