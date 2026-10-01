namespace ProxySample;

public class ImageProxy : IImage
{
	private readonly string _fileName;
	private RealImage? _realImage;

	public ImageProxy(string fileName)
	{
		_fileName = fileName;
	}

	public void Display()
	{
		// Create the real object only when needed
		_realImage ??= new RealImage(_fileName);

		_realImage.Display();
	}
}
