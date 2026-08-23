namespace AbstractFactory;

public class WindowsButton : IButton
{
	public void Render()
	{
		Console.WriteLine("🪟 Rendering a Windows Button");
	}
}
