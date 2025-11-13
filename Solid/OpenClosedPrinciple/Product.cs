namespace OpenClosedPrinciple;

public class Product
{
	public string Name;
	public Enumerations.Size Size;
	public Enumerations.Type Type;
	public Enumerations.Color Color;

	public Product(string name, Enumerations.Color color, Enumerations.Size size, Enumerations.Type type)
	{
		Name = name;
		Size = size;
		Type = type;
		Color = color;
	}
}
