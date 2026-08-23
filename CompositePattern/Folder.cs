namespace CompositePattern;

// Composite (Complex Item): representing a folder in the file system.
public class Folder : IFileSystemItem
{
	public string Name { get; }

	private readonly List<IFileSystemItem> _items = [];

	public Folder(string name)
	{
		Name = name;
	}

	public Folder Add(IFileSystemItem item)
	{
		_items.Add(item);

		return this;
	}

	public void Display(int depth = 0)
	{
		var indent = new string(' ', depth * 2);

		Console.WriteLine($"{indent}- {Name}");

		foreach (var item in _items)
		{
			item.Display(depth + 1);
		}
	}

	public long GetSize()
	{
		return _items.Sum(item => item.GetSize());
	}
}
