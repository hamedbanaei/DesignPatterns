public class RasterRenderer : IRenderer
{
	public void Render(Shape shape)
	{
		WriteLine($"Drawing pixels for the {shape.Name} with raster drawing method.");
	}
}
