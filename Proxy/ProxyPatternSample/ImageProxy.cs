namespace ProxyPatternSample
{
	public class ImageProxy : IPicture
	{
		public ImageProxy()
		{
			MyTimer = new System.Threading.Timer
				(
					new System.Threading.TimerCallback(MyTimerCallBack),
					this,
					10000,
					0
				);
		}

		protected IPicture MyPicture { get; set; }
		protected System.Threading.Timer MyTimer { get; set; }

		private bool _isDone;
		protected bool IsDone
		{
			get
			{
				return (_isDone);
			}
			set
			{
				_isDone = value;

				if (value)
				{
					OnFinallyImageLoaded(new System.EventArgs());
				}
			}
		}

		private void MyTimerCallBack(object obj)
		{
			IsDone = true;
			MyTimer.Dispose();
		}

		public event System.EventHandler FinallyImageLoaded;
		protected virtual void OnFinallyImageLoaded(System.EventArgs e)
		{
			if (FinallyImageLoaded != null)
			{
				FinallyImageLoaded(this, e);
			}
		}

		public System.Drawing.Image GetImage()
		{
			if (IsDone)
			{
				MyPicture = new FinalImage();
			}
			else
			{
				MyPicture = new Loading();
			}
			return (MyPicture.GetImage());
		}
	}
}
