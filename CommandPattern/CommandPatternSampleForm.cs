namespace CommandPattern
{
    public partial class CommandPatternSampleForm : Form
    {
        public CommandPatternSampleForm()
        {
            InitializeComponent();
        }

        private void ExecuteCommand(object sender, System.EventArgs e)
        {
            ICommandHolder xCommand = (ICommandHolder)sender;
            xCommand.Command.Execute();
        }
    }
}