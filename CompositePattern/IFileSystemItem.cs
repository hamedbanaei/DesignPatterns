namespace CompositePattern;

public interface IFileSystemItem
{
	string Name { get; }

	/// <summary>
	/// Displays the file system item and its children (if any) with indentation based on the depth in the hierarchy.
	/// </summary>
	/// <param name="depth">The depth of the item in the hierarchy.</param>
	void Display(int depth = 0);

	long GetSize();
}
