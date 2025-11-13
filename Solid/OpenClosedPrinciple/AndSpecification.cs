namespace OpenClosedPrinciple;

public class AndSpecification<T> : Abstractions.ISpecification<T>
{
	private Abstractions.ISpecification<T> First;
	private Abstractions.ISpecification<T> Second;

	public AndSpecification(Abstractions.ISpecification<T> first, Abstractions.ISpecification<T> second)
	{
		this.First = first;
		this.Second = second;
	}

	public bool IsSatisfied(Product p)
	{
		return First.IsSatisfied(p) && Second.IsSatisfied(p);
	}
}
