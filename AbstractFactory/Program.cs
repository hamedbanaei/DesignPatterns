using AbstractFactory;
using static System.Console;

WriteLine("Which platform?");

WriteLine("1 - Windows");
WriteLine("2 - macOS");

var choice = ReadLine();

// ********** ********** ********** ********** **********
// Abstract Factory without using of Factory Builder
// ********** ********** ********** ********** **********

WriteLine(System.Environment.NewLine);
WriteLine("Abstract Factory without using of Factory Builder");
{
	IUIFactory factory = choice switch
	{
		"2" => new MacUIFactory(),
		"1" => new WindowsUIFactory(),
		_ => throw new InvalidOperationException("Unsupported platform"),
	};

	var application = new Application(factory);

	application.Run();
}

// ********** ********** ********** ********** **********
// / Abstract Factory without using of Factory Builder
// ********** ********** ********** ********** **********



// ********** ********** ********** ********** **********
// Abstract Factory using Factory Builder
// ********** ********** ********** ********** **********

WriteLine(System.Environment.NewLine);
WriteLine("Abstract Factory using Factory Builder");
{
	OperatingSystems OS = (OperatingSystems)Enum.Parse(typeof(OperatingSystems), choice);
	IUIFactory factory = UIFactory.GetUIFactory(OS);

	var application = new Application(factory);

	application.Run();
}

// ********** ********** ********** ********** **********
// Abstract Factory using Factory Builder
// ********** ********** ********** ********** **********