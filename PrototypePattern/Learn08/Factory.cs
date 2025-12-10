namespace Learn08;

public class Factory : System.Object, IPrototype
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

	public object Clone()
	{
		return (MemberwiseClone());
	}

	public object DeepCopy()
	{
		Factory oFactory = (Factory)Clone();
		Person oManager = (Person)Manager.DeepCopy();

		oFactory.Manager = oManager;

		return (oFactory);
	}
}
