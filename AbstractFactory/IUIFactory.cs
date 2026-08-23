namespace AbstractFactory;

public interface IUIFactory
{
	IButton CreateButton();

	IDialog CreateDialog();
}
