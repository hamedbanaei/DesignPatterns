namespace BridgePattern;

public class Square : Shape
{
	private float side;

	public Square(IRenderer renderer, float radius) : base(renderer)
	{
		this.side = radius;
	}

	public override void Draw()
	{
		renderer.Render(this);
	}

	public override void Resize(float factor)
	{
		side *= factor;
	}
}
