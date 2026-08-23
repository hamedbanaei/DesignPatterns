namespace FlyweightPattern;

/// <summary>
/// FLYWEIGHT
/// Shared / Intrinsic (ذاتی) State
/// </summary>
public sealed class TreeType
{
	public string Name { get; }

	public string Color { get; }

	/// Imagine a picture as texture, I mean it gives a significant amount of RAM!
	public string Texture { get; }

	internal TreeType(string name, string color, string texture)
	{
		Name = name;
		Color = color;
		Texture = texture;
	}

	public void Draw(int x, int y, int height)
	{
		WriteLine(
			$"{Name,-6} | " +
			$"Color: {Color,-10} | " +
			$"Texture: {Texture,-12} | " +
			$"Position: ({x,3}, {y,3}) | " +
			$"Height: {height}m"
		);
	}
}
