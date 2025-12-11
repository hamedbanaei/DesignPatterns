namespace PrototypeSample.Hbx.Windows.Forms.Controls;

[System.Serializable]
public class Label : System.Windows.Forms.Label, System.Runtime.Serialization.ISerializable
{
	public Label()
	{
		Text = "Default Label";
		BackColor = System.Drawing.Color.Beige;
	}

	[System.ComponentModel.DefaultValue("Default Label")]
	public override string Text
	{
		get
		{
			return (base.Text);
		}
		set
		{
			base.Text = value;
		}
	}

	[System.ComponentModel.DefaultValue(typeof(System.Drawing.Color), "Beige")]
	public override System.Drawing.Color BackColor
	{
		get
		{
			return (base.BackColor);
		}
		set
		{
			base.BackColor = value;
		}
	}

	protected override void OnDoubleClick(System.EventArgs e)
	{
		PropertyGridForm frm =
			new PropertyGridForm();

		frm.SelectedObject = this;

		frm.ShowDialog();
	}

	public Label
		(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
		)
	{
		Text = info.GetString("Text") ?? "Default Label";

		Top = info.GetInt32("Top");
		Left = info.GetInt32("Left");

		object? objColor = info.GetValue("ForeColor", typeof(System.Drawing.Color));
		objColor ??= System.Drawing.Color.Black;

		ForeColor =
			(System.Drawing.Color)objColor;

		objColor = info.GetValue("BackColor", typeof(System.Drawing.Color));
		objColor ??= System.Drawing.Color.Beige;

		BackColor =
			(System.Drawing.Color)objColor;
	}

	public void GetObjectData
		(
			System.Runtime.Serialization.SerializationInfo info,
			System.Runtime.Serialization.StreamingContext context
		)
	{
		info.AddValue("Text", Text);

		info.AddValue("Top", Top);
		info.AddValue("Left", Left);

		info.AddValue("ForeColor", ForeColor);
		info.AddValue("BackColor", BackColor);
	}
}
