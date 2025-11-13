namespace OpenClosedPrinciple;

public class AndSpecification : Abstractions.ISpecification<OpenClosedPrinciple.Product>
{
	private Abstractions.ISpecification<Product> First;
	private Abstractions.ISpecification<Product> Second;

	public AndSpecification(Abstractions.ISpecification<Product> first, Abstractions.ISpecification<Product> second)
	{
		First = first;
		Second = second;
	}

	public bool IsSatisfied(OpenClosedPrinciple.Product p)
	{
		return First.IsSatisfied(p) && Second.IsSatisfied(p);
	}
}
