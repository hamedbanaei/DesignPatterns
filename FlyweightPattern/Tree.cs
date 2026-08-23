namespace FlyweightPattern;

/// <summary>
/// CONTEXT
/// Stores Unique / Extrinsic (بیرونی) State
/// </summary>
public sealed class Tree
{
	private readonly TreeType _treeType;

	public int X { get; }

	public int Y { get; }

	public int Height { get; }

	public Tree(int x, int y, int height, TreeType treeType)
	{
		X = x;
		Y = y;
		Height = height;
		_treeType = treeType;
	}

	public void Draw()
	{
		_treeType.Draw(X, Y, Height);
	}
}
