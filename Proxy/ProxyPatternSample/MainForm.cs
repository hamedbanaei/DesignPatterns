namespace ProxyPatternSample
{
	public partial class MainForm : System.Windows.Forms.Form
	{
		private ImageProxy _myImageProxy;
		protected ImageProxy MyImageProxy
		{
			get
			{
				if (_myImageProxy == null)
				{
					_myImageProxy = new ImageProxy();

					_myImageProxy.FinallyImageLoaded +=
						new System.EventHandler(MyImageProxy_FinallyImageLoaded);
				}
				return (_myImageProxy);
			}
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private void btnShowImage_Click(object sender, System.EventArgs e)
		{
			picPicture.Image = MyImageProxy.GetImage();
		}

		private void MyImageProxy_FinallyImageLoaded(object sender, System.EventArgs e)
		{
			picPicture.Image = MyImageProxy.GetImage();
		}
	}
}
