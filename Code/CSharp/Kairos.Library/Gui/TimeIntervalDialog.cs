/***********************************************************************************
* File:         TimeIntervalDialog.cs                                              *
* Contents:     Class TimeIntervalDialog                                           *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-31 19:19                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;

namespace Kairos.Library.Gui
{
	public partial class TimeIntervalDialog : Form
	{
		public TimeIntervalDialog()
		{
			InitializeComponent();

			this._dtpStart.Focus();
		}

		private void OnOk(object sender, EventArgs e)
		{
			this.Close();
		}

		private void OnCancel(object sender, EventArgs e)
		{

		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DateTime Start
		{
			get
			{
				return this._dtpStart.Value;
			}

			set
			{
				this._dtpStart.Value = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public DateTime Finish
		{
			get
			{
				return this._dtpFinish.Value;
			}

			set
			{
				this._dtpFinish.Value = value;
			}
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public string Comment
		{
			get
			{
				return this._txComment.Text;
			}

			set
			{
				this._txComment.Text = value;
			}
		}
	}
}
