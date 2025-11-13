namespace LiskovSubstitutionPrinciple;

public class Square : Rectangle
{
	// Violates LSP
	//public new int Width
	//{
	//  set { base.Width = base.Height = value; }
	//}

	// Violates LSP
	//public new int Height
	//{ 
	//  set { base.Width = base.Height = value; }
	//}

	public override int Width
	{
		set { base.Width = base.Height = value; }
	}

	public override int Height
	{
		set { base.Width = base.Height = value; }
	}
}
