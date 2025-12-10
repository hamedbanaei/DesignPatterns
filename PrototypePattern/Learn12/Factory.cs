namespace Learn12;

[System.Serializable]
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
			Manager.ShowInfo();
	}

	public Factory Clone()
	{
		return ((Factory)MemberwiseClone());
	}

	public Factory DeepCopy()
	{
		System.IO.MemoryStream oStream =
			new System.IO.MemoryStream();

		System.Runtime.Serialization.Formatters.Binary.BinaryFormatter oBinaryFormatter =
			new System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

		oBinaryFormatter.Serialize(oStream, this);

		// Note: Without this line you will get some error!
		oStream.Seek(0, System.IO.SeekOrigin.Begin);

		Factory oFactory =
			(Factory)oBinaryFormatter.Deserialize(oStream);

		//oStream.Close();
		oStream.Dispose();
		oStream = null;

		return (oFactory);
	}
}
