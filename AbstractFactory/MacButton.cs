namespace AbstractFactory;

public class MacButton : IButton
{
	public void Render()
	{
		Console.WriteLine("🍎 Rendering a macOS Button");
	}
}
