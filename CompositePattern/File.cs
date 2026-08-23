namespace CompositePattern;

// Leaf: representing a file in the file system.
public class File : IFileSystemItem
{
	public string Name { get; }

	private readonly long _size;

	public File(string name, long size)
	{
		Name = name;
		_size = size;
	}

	public void Display(int depth = 0)
	{
		var indent = new string(' ', depth * 2);

		Console.WriteLine(
			$"{indent}# {Name} ({_size:N0} bytes)");
	}

	public long GetSize()
	{
		return _size;
	}
}
