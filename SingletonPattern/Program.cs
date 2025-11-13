var obj = GenericSingleton.GenericSingleton<Factory>.Instance;
obj.Name = "Class-B12";

Console.WriteLine(GenericSingleton.GenericSingleton<Factory>.Instance.Name);

public class Factory
{
	public string Name { get; set; }
}
