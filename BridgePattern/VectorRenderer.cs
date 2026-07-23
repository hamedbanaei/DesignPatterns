public class VectorRenderer : IRenderer
{
	public void Render(Shape shape)
	{
		WriteLine($"Drawing the {shape.Name} with vector drawing method.");
	}
}
