namespace AdapterPattern
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

		private void MainForm_Load(object sender, System.EventArgs e)
		{
			lstFiles.SelectionMode = System.Windows.Forms.SelectionMode.One;
		}

		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			System.Windows.Forms.DialogResult oDialogResult;
			System.Windows.Forms.FolderBrowserDialog oDialog =
				new System.Windows.Forms.FolderBrowserDialog();

			oDialog.SelectedPath = System.Environment.SpecialFolder.MyDocuments.ToString();
			oDialog.Description = "Please select a path...";
			oDialogResult = oDialog.ShowDialog();
			if (oDialogResult == System.Windows.Forms.DialogResult.OK)
			{
				myFileListBoxAdapter.ClearFiles();
				myFileListViewAdapter.ClearFiles();
				myFileTreeViewAdapter.ClearFiles();

				System.IO.DirectoryInfo oDirectoryInfo =
					new System.IO.DirectoryInfo(oDialog.SelectedPath);

				foreach (System.IO.FileInfo oFileInfo in oDirectoryInfo.GetFiles())
				{
					myFileListBoxAdapter.AddNewFileInfo(oFileInfo);
					myFileListViewAdapter.AddNewFileInfo(oFileInfo);
					myFileTreeViewAdapter.AddNewFileInfo(oFileInfo);
				}
			}
		}

		private void btnClear_Click(object sender, System.EventArgs e)
		{
			myFileListBoxAdapter.ClearFiles();
			myFileListViewAdapter.ClearFiles();
			myFileTreeViewAdapter.ClearFiles();
		}
	}
}