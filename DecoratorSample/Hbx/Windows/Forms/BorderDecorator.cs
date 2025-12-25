namespace Hbx.Windows.Forms;

public class BorderDecorator : Decorator
{
	public BorderDecorator(System.Windows.Forms.Control control)
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
				System.Drawing.Pens.Red,
				e.X,
				e.Y,
				2,
				2
			);
	}

	public override void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e)
	{
		System.Drawing.Pen oPen = new System.Drawing.Pen(System.Drawing.Color.Red);

		e.Graphics.DrawRectangle(oPen, 0, 0, Control.Width - 1, Control.Height - 1);
		e.Graphics.DrawRectangle(oPen, 0, 0, Control.Width - 2, Control.Height - 2);
		e.Graphics.DrawRectangle(oPen, 0, 0, Control.Width - 3, Control.Height - 3);
	}
}
