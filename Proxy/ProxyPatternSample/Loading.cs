namespace ProxyPatternSample
{
	internal class Loading : IPicture
	{
		public System.Drawing.Image GetImage()
		{
			return(System.Drawing.Image.FromFile(@"Images\Loading.jpg"));
		}
	}
}
