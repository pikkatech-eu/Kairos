using Kairos.Library.Gui.Dialogs;

namespace Kairos
{
	public partial class KairosForm : Form
	{
		public KairosForm()
		{
			InitializeComponent();
		}

		private void OnCollectionNew(object sender, EventArgs e)
		{
			ItemPropertiesDialog dialog = new ItemPropertiesDialog();

			if (dialog.ShowDialog() == DialogResult.OK)
			{

			}
		}
	}
}
