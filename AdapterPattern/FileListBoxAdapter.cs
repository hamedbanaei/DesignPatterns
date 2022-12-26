using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
	public class FileListBoxAdapter : System.ComponentModel.Component, IFileListAdapterObject
	{
		public FileListBoxAdapter()
		{
		}

		public FileListBoxAdapter
			(System.Windows.Forms.ListBox listBox)
		{
			MyListBox = listBox;
		}

		[System.ComponentModel.DefaultValue(null)]
		public System.Windows.Forms.ListBox MyListBox { get; set; }

		public int SelectedFileIndex
		{
			get
			{
				return (MyListBox.SelectedIndex);
			}
		}

		public void ClearFiles()
		{
			MyListBox.Items.Clear();
		}

		public void DeselectFiles()
		{
			MyListBox.SelectedIndex = -1;
		}

		public void AddNewFileInfo(System.IO.FileInfo fileInfo)
		{
			string strFileInfo;
			long lngFileLength = fileInfo.Length;

			switch (lngFileLength)
			{
				case 0:
					{
						strFileInfo = fileInfo.Name.PadRight(60, '.') + "Zero Byte!";
						break;
					}

				case 1:
					{
						strFileInfo = fileInfo.Name.PadRight(60, '.') + "1 Byte!";
						break;
					}

				default:
					{
						strFileInfo = fileInfo.Name.PadRight(60, '.') + lngFileLength.ToString("#,##0 Bytes");
						break;
					}
			}

			MyListBox.Items.Add(strFileInfo);
		}
	}
}
