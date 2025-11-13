namespace InterfaceSegregationPrinciple;

public class Document
{
}

public interface IMachine
{
	void Fax(Document document);

	void Scan(Document document);

	void Print(Document document);
}

// It's OK if you just and only need a multifunction machine
public class MultiFunctionPrinter : IMachine
{
	public void Fax(Document document)
	{
		// Body for Fax Document
	}

	public void Scan(Document document)
	{
		// Body for Scan Document
	}

	public void Print(Document document)
	{
		// Body for Print Document
	}
}

public class OldFashionedPrinter : IMachine
{
	public void Print(Document document)
	{
		// Yep, It can print
	}

	public void Fax(Document document)
	{
		// It can't fax, should we throw an exception? Give a message? or what?
		throw new System.NotImplementedException();
	}

	public void Scan(Document document)
	{
		// It can't scan, should we throw an exception? Give a message? or what?
		throw new System.NotImplementedException();
	}
}

public interface IPrinter
{
	void Print(Document document);
}

public interface IScanner
{
	void Scan(Document document);
}

public class Printer : IPrinter
{
	public void Print(Document document)
	{
		// Body for Print Document
	}
}

public class Photocopier : IPrinter, IScanner
{
	public void Scan(Document document)
	{
		// Body for Scan Document
	}

	public void Print(Document document)
	{
		// Body for Print Document
	}
}

public interface IMultiFunctionDevice : IPrinter, IScanner // ...
{
}

public struct MultiFunctionMachine : IMultiFunctionDevice
{
	// Compose this out of several modules
	private IPrinter Printer;
	private IScanner Scanner;

	// Injection via constructor
	public MultiFunctionMachine(IPrinter printer, IScanner scanner)
	{
		Printer = printer;
		Scanner = scanner;
	}

	public void Print(Document document)
	{
		Printer.Print(document);
	}

	public void Scan(Document document)
	{
		Scanner.Scan(document);
	}
}
