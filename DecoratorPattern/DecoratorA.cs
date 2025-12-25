namespace DecoratorPattern;

public class DecoratorA : IComponent
{
	public DecoratorA(IComponent component)
	{
		_component = component;
	}

	private IComponent _component;

	public string Operation()
	{
		string s =
			_component.Operation();

		s +=
			" and listening to Classic FM ";

		return (s);
	}
}
