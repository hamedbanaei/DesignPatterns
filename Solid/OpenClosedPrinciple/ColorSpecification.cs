namespace OpenClosedPrinciple;

public class ColorSpecification : Abstractions.ISpecification<Product>
{
	private Enumerations.Color Color;

	public ColorSpecification(Enumerations.Color color)
	{
		Color = color;
	}

	public bool IsSatisfied(Product p)
	{
		return p.Color == Color;
	}
}
