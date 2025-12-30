namespace Hbx.Windows.Forms;

public class OKDecorator : Decorator
{
	public OKDecorator(System.Windows.Forms.Control control)
	{
		Control = control;

		Control.MouseLeave += new System.EventHandler(OnMouseLeave);
		Control.Paint += new System.Windows.Forms.PaintEventHandler(OnPaint);
		Control.MouseMove += new System.Windows.Forms.MouseEventHandler(OnMouseMove);
	}

	public override System.Windows.Forms.Control Control { get; set; }

	public override void OnMouseEnter(object sender, System.EventArgs e)
	{
	}

	public override void OnMouseLeave(object sender, System.EventArgs e)
	{
		Control.Invalidate();
	}

	public override void OnMouseMove(object sender, System.Windows.Forms.MouseEventArgs e)
	{
		System.Drawing.Graphics oGraphics = Control.CreateGraphics();

		oGraphics.DrawRectangle
			(
				System.Drawing.Pens.Blue,
				e.X - 10,
				e.Y - 10,
				5,
				5
			);
	}

	public override void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
	{
		System.Drawing.Pen oPen =
			new System.Drawing.Pen(System.Drawing.Color.Red);

		e.Graphics.DrawString
			(
				"OK",
				new System.Drawing.Font("Verdana", 10, System.Drawing.FontStyle.Bold),
				System.Drawing.Brushes.Red,
				10,
				10
			);
	}
}
