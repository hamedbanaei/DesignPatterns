namespace AdapterPattern
{
    public interface IFileListAdapterObject
    {
        int SelectedFileIndex
        {
            get;
        }

        void ClearFiles();
        void DeselectFiles();
        void AddNewFileInfo(System.IO.FileInfo fileInfo);
    }
}
