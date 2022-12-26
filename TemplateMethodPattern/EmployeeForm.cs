namespace TemplateMethodPattern
{
	public partial class EmployeeForm : NavigationForm
	{
		public EmployeeForm()
		{
			InitializeComponent();
		}

		protected override void SetControlValuesToDefaultValue()
		{
			txtFullName.Text = string.Empty;

			txtFullName.Enabled = true;
		}

		protected override bool CheckFormValidation()
		{
			bool blnResult = true;

			txtFullName.Text = txtFullName.Text.Trim();
			if (txtFullName.Text == string.Empty)
			{
				blnResult = false;

				string strErrorMessage =
					"Filling FullName field is mandatory!";

				myErrorProvider.SetError(txtFullName, strErrorMessage);
			}
			else
			{
				myErrorProvider.SetError(txtFullName, string.Empty);
			}

			return (blnResult);
		}

		protected override void DisableControls()
		{
			txtFullName.Enabled = false;
		}

		protected override void UpdateRecord()
		{
			System.Windows.Forms.MessageBox.Show("Updated Successfully.");
		}
	}
}
