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
		// Oldest Way
		//if (_realImage == null)
		//{
		//	_realImage = new RealImage(_fileName);
		//}
		// / Oldest Way

		// Old Way - Pattern Matching
		//if (_realImage is null)
		//{
		//	_realImage = new RealImage(_fileName);
		//}
		// / Old Way - Pattern Matching

		// Create the real object only when needed
		_realImage ??= new RealImage(_fileName);

		_realImage.Display();
	}
}
