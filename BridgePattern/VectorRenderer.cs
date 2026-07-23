namespace BridgePattern;

public class VectorRenderer : IRenderer
{
	public void RenderCircle(float radius)
	{
		WriteLine($"Drawing a circle of radius {radius} with vector drawing method.");
	}
}
