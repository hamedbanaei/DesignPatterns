namespace AbstractFactory;

public class MacDialog : IDialog
{
	public void Show()
	{
		Console.WriteLine("🍎 Showing a macOS Dialog");
	}
}
