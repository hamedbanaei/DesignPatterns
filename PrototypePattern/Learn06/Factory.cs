namespace Learn06;

public class Factory : System.Object, System.ICloneable
{
	public Factory(string name, Person manager)
	{
		Name = name;
		Manager = manager;
	}

	public string Name { get; set; }
	public Person Manager { get; set; }

	public void ShowInfo()
	{
		System.Console.WriteLine("Factory Name: " + Name);

		if (Manager != null)
		{
			Manager.ShowInfo();
		}
	}

	/// <summary>
	/// Shallow Copy: کپی سطحی
	/// </summary>
	public object Clone()
	{
		return (MemberwiseClone());
	}

	/// <summary>
	/// Shallow Copy: کپی سطحی
	/// </summary>
	public Factory Copy()
	{
		return ((Factory)Clone());
	}
}
