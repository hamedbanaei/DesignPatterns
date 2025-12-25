namespace DecoratorPattern;

public class Utility
{
	public static void Display(string text, IComponent component)
	{
		System.Console.WriteLine(text + component.Operation());
	}
}
