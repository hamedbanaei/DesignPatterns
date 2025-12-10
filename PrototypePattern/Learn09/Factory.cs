namespace Learn09;

public class Factory : System.Object, IPrototype<Factory>
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

	public Factory Clone()
	{
		return ((Factory)MemberwiseClone());
	}

	public Factory DeepCopy()
	{
		Person oManager = Manager.Clone();
		Factory oFactory = Clone();

		oFactory.Manager = oManager;

		return (oFactory);
	}
}
