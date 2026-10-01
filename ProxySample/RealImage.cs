namespace ProxySample;

public class RealImage : IImage
{
	private readonly string _fileName;

	public RealImage(string fileName)
	{
		_fileName = fileName;
		LoadFromDisk();
	}

	private void LoadFromDisk()
	{
		Console.WriteLine($"Loading {_fileName} from disk...");
	}

	public void Display()
	{
		Console.WriteLine($"Displaying {_fileName}");
	}
}
