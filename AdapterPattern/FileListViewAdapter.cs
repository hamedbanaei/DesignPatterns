namespace AdapterPattern
{
	public class FileListViewAdapter : System.ComponentModel.Component, IFileListAdapterObject
	{
		public FileListViewAdapter()
		{
		}

		public FileListViewAdapter
			(System.Windows.Forms.ListView listView)
		{
			MyListView = listView;
		}

		[System.ComponentModel.DefaultValue(null)]
		private System.Windows.Forms.ListView _myListView;
		public System.Windows.Forms.ListView MyListView
		{
			get
			{
				return (_myListView);
			}
			set
			{
				_myListView = value;

				if (value != null)
				{
					_myListView.GridLines = true;
					_myListView.MultiSelect = false;
					_myListView.FullRowSelect = true;
					_myListView.View = System.Windows.Forms.View.Details;

					_myListView.Columns.Clear();

					_myListView.Columns.Add("File", 400);
				}
			}
		}

		public int SelectedFileIndex
		{
			get
			{
				if (MyListView.SelectedIndices.Count == 0)
				{
					return (-1);
				}
				else
				{
					return (MyListView.SelectedIndices[0]);
				}
			}
		}

		public void ClearFiles()
		{
			MyListView.Items.Clear();
		}

		public void DeselectFiles()
		{
			foreach (System.Windows.Forms.ListViewItem oListViewItem in MyListView.SelectedItems)
			{
				oListViewItem.Selected = false;
			}
		}

		public void AddNewFileInfo(System.IO.FileInfo fileInfo)
		{
			string strFileInfo;
			long lngFileLength = fileInfo.Length;

			switch (lngFileLength)
			{
				case 0:
					{
						strFileInfo = fileInfo.Name.PadRight(40, '.') + "Zero Byte!";
						break;
					}

				case 1:
					{
						strFileInfo = fileInfo.Name.PadRight(40, '.') + "1 Byte!";
						break;
					}

				default:
					{
						strFileInfo = fileInfo.Name.PadRight(40, '.') + lngFileLength.ToString("#,##0 Bytes");
						break;
					}
			}

			MyListView.Items.Add(strFileInfo);
		}
	}
}
