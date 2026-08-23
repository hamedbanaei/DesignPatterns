namespace AbstractFactory;

public class WindowsUIFactory : IUIFactory
{
	public IButton CreateButton()
	{
		return new WindowsButton();
	}

	public IDialog CreateDialog()
	{
		return new WindowsDialog();
	}
}
