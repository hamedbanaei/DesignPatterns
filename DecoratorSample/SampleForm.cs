namespace DecoratorSample
{
    public partial class SampleForm : Form
    {
        public SampleForm()
        {
            InitializeComponent();
        }

		private void SampleForm_Load(object sender, System.EventArgs e)
		{
			Hbx.Windows.Forms.OKDecorator oOKDecorator1 = new Hbx.Windows.Forms.OKDecorator(picPicture2);

			Hbx.Windows.Forms.BorderDecorator oBorderDecorator1 = new Hbx.Windows.Forms.BorderDecorator(picPicture3);

			Hbx.Windows.Forms.OKDecorator oOKDecorator2 = new Hbx.Windows.Forms.OKDecorator(picPicture4);
			Hbx.Windows.Forms.BorderDecorator oBorderDecorator2 = new Hbx.Windows.Forms.BorderDecorator(picPicture4);



			Hbx.Windows.Forms.OKDecorator oOKDecorator3 = new Hbx.Windows.Forms.OKDecorator(button2);

			Hbx.Windows.Forms.BorderDecorator oBorderDecorator3 = new Hbx.Windows.Forms.BorderDecorator(button3);

			Hbx.Windows.Forms.OKDecorator oOKDecorator4 = new Hbx.Windows.Forms.OKDecorator(button4);
			Hbx.Windows.Forms.BorderDecorator oBorderDecorator4 = new Hbx.Windows.Forms.BorderDecorator(button4);
		}
	}
}
