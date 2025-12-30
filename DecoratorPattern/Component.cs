namespace DecoratorPattern;

public class Component : IComponent
{
	public string Operation()
	{
		return ("I am walking ");
	}
}