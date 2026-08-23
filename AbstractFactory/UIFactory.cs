namespace AbstractFactory;

public class UIFactory
{
	public static IUIFactory GetUIFactory(OperatingSystems operatingSystem)
	{
		return operatingSystem switch
		{
			OperatingSystems.MacOS => new MacUIFactory(),
			OperatingSystems.Windows => new WindowsUIFactory(),
			_ => throw new InvalidOperationException("Unsupported platform"),
		};
	}
}
