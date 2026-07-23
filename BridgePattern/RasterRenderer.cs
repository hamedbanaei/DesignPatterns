namespace BridgePattern;

public class RasterRenderer : IRenderer
{
	public void RenderCircle(float radius)
	{
		WriteLine($"Drawing pixels for circle of radius {radius} with raster drawing method.");
	}
}
