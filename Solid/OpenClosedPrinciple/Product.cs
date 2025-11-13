namespace OpenClosedPrinciple;

public class Product
{
	public string Name;
	public Enumerations.Color Color;
	public Enumerations.Size Size;

	public Product(string name, Enumerations.Color color, Enumerations.Size size)
	{
		Name = name;
		Size = size;
		Color = color;
	}
}
