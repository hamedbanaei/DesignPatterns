namespace OpenClosedPrinciple;

public class SizeSpecification : Abstractions.ISpecification<Product>
{
	private Enumerations.Size Size;

	public SizeSpecification(Enumerations.Size size)
	{
		Size = size;
	}

	public bool IsSatisfied(Product p)
	{
		return p.Size == Size;
	}
}
