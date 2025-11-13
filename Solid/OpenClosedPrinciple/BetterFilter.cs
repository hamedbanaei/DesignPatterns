namespace OpenClosedPrinciple;

public class BetterFilter : Abstractions.IFilter<Product>
{
	public IEnumerable<Product> Filter(IEnumerable<Product> items, Abstractions.ISpecification<Product> spec)
	{
		foreach (var i in items)
			if (spec.IsSatisfied(i))
				yield return i;
	}
}
