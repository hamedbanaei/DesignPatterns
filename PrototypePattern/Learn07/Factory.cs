namespace Learn07;

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
	/// Shallow Copy
	/// </summary>
	public object Clone()
	{
		return ((Factory)MemberwiseClone());
	}

	/// <summary>
	/// Shallow Copy
	/// </summary>
	public Factory Copy()
	{
		return ((Factory)Clone());
	}

	/// <summary>
	/// Deep Copy: کپی عميق
	/// </summary>
	public Factory DeepCopy()
	{
		Factory oFactory = Copy();
		Person oManager = Manager.Copy();

		oFactory.Manager = oManager;

		return (oFactory);
	}
}
