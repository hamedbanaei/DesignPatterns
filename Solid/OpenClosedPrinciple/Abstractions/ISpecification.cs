namespace Abstractions;

public interface ISpecification<T>
{
	bool IsSatisfied(OpenClosedPrinciple.Product p);
}
