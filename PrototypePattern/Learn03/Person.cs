namespace Learn03;

public class Person
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

	/// <summary>
	/// Copy Constructor
	/// </summary>
	/// <param name="person">Person who we want to copy.</param>
	public Person(Person person)
	{
		Age = person.Age;
		FullName = person.FullName;
	}

	public int Age { get; set; }
	public string FullName { get; set; }

	public Person Copy()
	{
		//Person oPerson = new Person();

		//oPerson.Age = Age;
		//oPerson.FullName = FullName;

		Person oPerson = new Person(this);

		return (oPerson);
	}

	public void ShowInfo()
	{
		System.Console.WriteLine($"I'm {FullName} and {Age} years old.");
	}
}
