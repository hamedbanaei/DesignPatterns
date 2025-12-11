namespace PrototypeSample.Hbx.Windows.Forms;

public partial class PropertyGridForm : System.Windows.Forms.Form
{
	public PropertyGridForm()
	{
		InitializeComponent();
	}

	[System.ComponentModel.DefaultValue(null)]
	public System.Object SelectedObject
	{
		get
		{
			return (myPropertyGrid.SelectedObject);
		}
		set
		{
			myPropertyGrid.SelectedObject = value;
		}
	}
}