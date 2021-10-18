namespace ProxyPatternSample
{
	internal class FinalImage : IPicture
	{
		public System.Drawing.Image GetImage()
		{
			return (System.Drawing.Image.FromFile(@"Images\Innocence.jpg"));
		}
	}
}
