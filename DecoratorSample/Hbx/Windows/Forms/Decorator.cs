namespace Hbx.Windows.Forms;

public abstract class Decorator : System.Windows.Forms.Control
{
	public abstract System.Windows.Forms.Control Control { get; set; }

	public abstract void OnMouseEnter(object sender, System.EventArgs e);
	public abstract void OnMouseLeave(object sender, System.EventArgs e);
	public abstract void OnMouseMove(object sender, System.Windows.Forms.MouseEventArgs e);

	public abstract void OnPaint(object sender, System.Windows.Forms.PaintEventArgs e);
}
