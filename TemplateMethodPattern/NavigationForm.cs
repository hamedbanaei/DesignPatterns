namespace TemplateMethodPattern
{
	public partial class NavigationForm : BaseForm
	{
		public enum Modes
		{
			Edit,
			AddNew,
			Navigation
		}

		public NavigationForm()
		{
			InitializeComponent();

			Mode = Modes.Navigation;
		}

		[System.ComponentModel.DefaultValue(Modes.Navigation)]
		public Modes Mode { get; set; }

		private void NavigationForm_Load(object sender, System.EventArgs e)
		{
			SetButtonsForNavigationMode();
			DisableControls();
		}

		protected virtual void SetButtonsForNavigationMode()
		{
			btnEdit.Enabled = true;
			btnAddNew.Enabled = true;

			btnUpdate.Enabled = false;
			btnCancelUpdate.Enabled = false;
		}

		private void btnAddNew_Click(object sender, System.EventArgs e)
		{
			Mode = Modes.AddNew;

			SetButtonsForEditMode();

			lblTitle.Text = "Insert";

			SetControlValuesToDefaultValue();
		}

		protected virtual void SetControlValuesToDefaultValue()
		{
			throw (new System.NotImplementedException("SetControlValuesToDefaultValue()"));
		}

		protected virtual void SetButtonsForEditMode()
		{
			btnEdit.Enabled = false;
			btnAddNew.Enabled = false;

			btnUpdate.Enabled = true;
			btnCancelUpdate.Enabled = true;
		}

		private void btnEdit_Click(object sender, System.EventArgs e)
		{
			Mode = Modes.Edit;

			SetButtonsForEditMode();

			lblTitle.Text = "Edit";

			SetControlValuesToDefaultValue();
		}

		private void btnUpdate_Click(object sender, System.EventArgs e)
		{
			if (CheckFormValidation())
			{
				Mode = Modes.Navigation;

				UpdateRecord();

				SetButtonsForNavigationMode();
				SetControlValuesToDefaultValue();

				lblTitle.Text = string.Empty;

				DisableControls();
			}
		}

		protected virtual void UpdateRecord()
		{
			throw (new System.NotImplementedException("UpdateRecord()"));
		}

		protected virtual bool CheckFormValidation()
		{
			throw (new System.NotImplementedException("CheckFormValidation()"));
		}

		protected virtual void DisableControls()
		{
			throw (new System.NotImplementedException("DisableControls()"));
		}

		private void btnCancelUpdate_Click(object sender, System.EventArgs e)
		{
			Mode = Modes.Navigation;

			SetButtonsForNavigationMode();
			SetControlValuesToDefaultValue();

			lblTitle.Text = string.Empty;

			DisableControls();
		}
	}
}
