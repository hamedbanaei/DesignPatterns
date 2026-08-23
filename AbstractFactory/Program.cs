WriteLine("Which platform?");

WriteLine("1 - macOS");
WriteLine("2 - Windows");

var choice = ReadLine();

// ********** ********** ********** ********** **********
// Abstract Factory without using of Factory Builder
// ********** ********** ********** ********** **********

WriteLine(System.Environment.NewLine);
WriteLine("Abstract Factory without using of Factory Builder");
{
	IUIFactory factory = choice switch
	{
		"1" => new MacUIFactory(),
		"2" => new WindowsUIFactory(),
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