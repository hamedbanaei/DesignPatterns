namespace FlyweightPattern;

/// <summary>
/// FLYWEIGHT FACTORY
/// Creates and Reuses Flyweights (Shared States)
/// </summary>
public sealed class TreeTypeFactory
{
	private readonly Dictionary<string, TreeType> _treeTypes = [];

	public TreeType GetTreeType(string name, string color, string texture)
	{
		var key = $"{name}#{color}#{texture}";

		if (_treeTypes.TryGetValue(key, out var existingTreeType))
		{
			Console.WriteLine($" => Reusing: {name} TreeType");

			return existingTreeType;
		}

		WriteLine($"+ Creating: {name} TreeType");

		var newTreeType = new TreeType(name, color, texture);

		_treeTypes[key] = newTreeType;

		return newTreeType;
	}

	public int Count => _treeTypes.Count;
}
