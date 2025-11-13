namespace OpenClosedPrinciple;

/// <summary>
/// Violates OCP(open for extension but closed for modification)
/// </summary>
public class OldProductFilter
{
	public IEnumerable<Product> FilterByColor(IEnumerable<Product> products,Enumerations.Color color)
	{
		foreach (var p in products)
			if (p.Color == color)
				yield return p;
	}

	public static IEnumerable<Product> FilterBySize(IEnumerable<Product> products, Enumerations.Size size)
	{
		foreach (var p in products)
			if (p.Size == size)
				yield return p;
	}

	public static IEnumerable<Product> FilterBySizeAndColor(IEnumerable<Product> products, Enumerations.Size size, Enumerations.Color color)
	{
		foreach (var p in products)
			if (p.Size == size && p.Color == color)
				yield return p;
	}
}
