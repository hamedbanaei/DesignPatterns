namespace AdapterPattern
{
	public class FileTreeViewAdapter : System.ComponentModel.Component, IFileListAdapterObject
	{
		public FileTreeViewAdapter()
		{
		}

		public FileTreeViewAdapter
			(System.Windows.Forms.TreeView treeView)
		{
			MyTreeView = treeView;
		}

		[System.ComponentModel.DefaultValue(null)]
		public System.Windows.Forms.TreeView MyTreeView { get; set; }

		public int SelectedFileIndex
		{
			get
			{
				return (MyTreeView.SelectedNode.Index);
			}
		}

		public void ClearFiles()
		{
			MyTreeView.Nodes.Clear();
		}

		public void DeselectFiles()
		{
			MyTreeView.SelectedNode = null;
		}

		public void AddNewFileInfo(System.IO.FileInfo fileInfo)
		{
			string strFileLength;
			long lngFileLength = fileInfo.Length;

			switch (lngFileLength)
			{
				case 0:
					{
						strFileLength = "".PadRight(40, '.') + "Zero Byte!";
						break;
					}

				case 1:
					{
						strFileLength = "".PadRight(40, '.') + "1 Byte!";
						break;
					}

				default:
					{
						strFileLength = "".PadRight(40, '.') + lngFileLength.ToString("#,##0 Bytes");
						break;
					}
			}

			System.Windows.Forms.TreeNode oTreeNode = MyTreeView.Nodes.Add(fileInfo.Name);
			oTreeNode.Nodes.Add(strFileLength);

			MyTreeView.ExpandAll();
		}
	}
}
