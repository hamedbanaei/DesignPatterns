namespace OpenClosedPrinciple;

public class TypeSpecification : Abstractions.ISpecification<Product>
{
	private Enumerations.Type Type;

	public TypeSpecification(Enumerations.Type type)
	{
		Type = type;
	}

	public bool IsSatisfied(Product p)
	{
		return p.Type == Type;
	}
}
