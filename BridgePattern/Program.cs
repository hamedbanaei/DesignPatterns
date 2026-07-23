var raster = new RasterRenderer();
var vector = new VectorRenderer();
var circle = new Circle(vector, 5);
circle.Draw();
circle.Resize(2);
circle.Draw();

var square = new Square(raster, 10);
square.Draw();
square.Resize(1.5f);
square.Draw();

//decimal d = 14.5m;
