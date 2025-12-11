namespace PrototypeSample;

public partial class MainForm : System.Windows.Forms.Form
{
	public MainForm()
	{
		InitializeComponent();
	}

	private void MainForm_Load(object sender, System.EventArgs e)
	{
		System.Collections.Generic.List
			<Hbx.Windows.Forms.Controls.Label> oControls = null;

		System.IO.FileStream oStream = null;

		try
		{
			oStream =
				new System.IO.FileStream
					(
						@"TEST.BIN",
						System.IO.FileMode.Open,
						System.IO.FileAccess.Read
					);

			System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
				oBinaryFormatter =
				new 
				System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

			oControls =
				(System.Collections.Generic.List<Hbx.Windows.Forms.Controls.Label>)
				oBinaryFormatter.Deserialize(oStream);

			pnlMain.Controls.Clear();
			foreach (Hbx.Windows.Forms.Controls.Label oLabel in oControls)
			{
				pnlMain.Controls.Add(oLabel);
			}
		}
		catch (System.Exception ex)
		{
			System.Console.WriteLine(ex.Message);
		}
		finally
		{
			if (oStream != null)
			{
				//oStream.Close();
				oStream.Dispose();
				oStream = null;
			}
		}
	}

	private void btnAddLabel_Click(object sender, System.EventArgs e)
	{
		Hbx.Windows.Forms.Controls.Label oLabel =
				new Hbx.Windows.Forms.Controls.Label();

		int intControlCount =
			pnlMain.Controls.Count;

		oLabel.Top = (intControlCount + 1) * 25;
		oLabel.Left = (intControlCount + 1) * 25;

		pnlMain.Controls.Add(oLabel);
	}

	private void MainForm_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
	{
		System.Collections.Generic.List
			<Hbx.Windows.Forms.Controls.Label>
			oControls =
			new 
			System.Collections.Generic.List
			<Hbx.Windows.Forms.Controls.Label>();

		foreach (Hbx.Windows.Forms.Controls.Label oLabel in pnlMain.Controls)
		{
			oControls.Add(oLabel);
		}

		System.IO.FileStream oStream = null;
		try
		{
			oStream =
				new System.IO.FileStream
				(
					@"TEST.BIN",
					System.IO.FileMode.Create,
					System.IO.FileAccess.Write
				);

			System.Runtime.Serialization.Formatters.Binary.BinaryFormatter
				oBinaryFormatter =
				new
				System.Runtime.Serialization.Formatters.Binary.BinaryFormatter();

			oBinaryFormatter.Serialize(oStream, oControls);
		}
		catch (System.Exception ex)
		{
			System.Windows.Forms.MessageBox.Show(ex.Message);
		}
		finally
		{
			if (oStream != null)
			{
				//oStream.Close();
				oStream.Dispose();
				oStream = null;
			}
		}
	}

	private void btnClear_Click(object sender, System.EventArgs e)
	{
		pnlMain.Controls.Clear();
	}
}
