namespace AbstractFactory;

public class Application
{
	private readonly IUIFactory _factory;

	public Application(IUIFactory factory)
	{
		_factory = factory;
	}

	public void Run()
	{
		var button = _factory.CreateButton();
		var dialog = _factory.CreateDialog();

		button.Render();
		dialog.Show();
	}
}
