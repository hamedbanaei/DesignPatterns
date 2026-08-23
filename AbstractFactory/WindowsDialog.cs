namespace AbstractFactory;

public class WindowsDialog : IDialog
{
	public void Show()
	{
		Console.WriteLine("# Showing a Windows Dialog");
	}
}
