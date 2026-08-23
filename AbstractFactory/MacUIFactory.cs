namespace AbstractFactory;

public class MacUIFactory : IUIFactory
{
	public IButton CreateButton()
	{
		return new MacButton();
	}

	public IDialog CreateDialog()
	{
		return new MacDialog();
	}
}
