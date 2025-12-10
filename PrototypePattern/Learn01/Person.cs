namespace Learn01;

public class Person : System.Object
{
	public Person()
	{
		Age = 0;
		FullName = string.Empty;
	}

	//public Person(string fullName)
	//{
	//    Age = 0;
	//    FullName = fullName;
	//}

	public Person(string fullName)
		: this()
	{
		FullName = fullName;
	}

	//public Person(string fullName, int age)
	//{
	//    Age = age;
	//    FullName = fullName;
	//}

	public Person(string fullName, int age)
		: this(fullName)
	{
		Age = age;
	}

	public int Age { get; set; }
	public string FullName { get; set; }

	public void ShowInfo()
	{
		System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
	}
}
