using ProxySample;

IImage image = new ImageProxy("MyPhoto.jpg");

Console.WriteLine("Proxy created.");
Console.WriteLine("Real image has NOT been loaded yet.");

Console.WriteLine("\nFirst call:");
image.Display();

Console.WriteLine("\nSecond call:");
image.Display();