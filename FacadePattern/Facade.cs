namespace FacadePattern;

public class Facade
{
	protected Subsystem1 subsystem1;

	protected Subsystem2 subsystem2;

	public Facade(Subsystem1 subsystem1, Subsystem2 subsystem2)
	{
		this.subsystem1 = subsystem1;
		this.subsystem2 = subsystem2;
	}

	public string Operation()
	{
		string result = "Facade initializes subsystems:\n";
		result += this.subsystem1.Operation1();
		result += this.subsystem2.Operation1();
		result += "Facade orders subsystems to perform the action:\n";
		result += this.subsystem1.OperationN();
		result += this.subsystem2.OperationZ();
		return result;
	}
}
