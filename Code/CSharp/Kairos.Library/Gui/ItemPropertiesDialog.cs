using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kairos.Library.Gui.Dialogs
{
	public partial class ItemPropertiesDialog : Form
	{
		public ItemPropertiesDialog()
		{
			InitializeComponent();
			this._txName.Select();
		}

		private void OnOk(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnCancel(object sender, EventArgs e)
		{

		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string ItemName
		{
			get
			{
				return this._txName.Text;
			}

			set
			{
				this._txName.Text = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string ItemDescription
		{
			get
			{
				return this._txDescription.Text;
			}

			set
			{
				this._txDescription.Text = value;
			}
		}
	}
}
