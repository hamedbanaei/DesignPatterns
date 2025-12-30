namespace DecoratorPattern;

public class DecoratorB : IComponent
{
	public DecoratorB(IComponent component)
	{
		_component = component;
	}

	private IComponent _component;

	public string Operation()
	{
		string s =
			_component.Operation();

		s += " and buying some DVD ";

		return (s);
	}
}
