namespace Learn12;

[System.Serializable]
public class Person : System.Object, IPrototype<Person>
{
	//public Person()
	//{
	//    Age = 0;
	//    FullName = string.Empty;
	//}

	//public Person(string fullName)
	//    : this()
	//{
	//    FullName = fullName;
	//}

	public Person(string fullName)
	{
		Age = 0;
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
		System.Console.WriteLine("\n\r**************************************************\n\r");
		System.Console.WriteLine("I'm {0} and {1} years old.", FullName, Age);
		System.Console.WriteLine("\n\r**************************************************\n\r");
	}

	public Person Clone()
	{
		return ((Person)MemberwiseClone());
	}

	public Person DeepCopy()
	{
		return ((Person)Clone());
	}
}
