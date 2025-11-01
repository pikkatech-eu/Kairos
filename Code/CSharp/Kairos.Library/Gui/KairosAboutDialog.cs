/***********************************************************************************
* File:         KairosAboutDialog.cs                                                  *
* Contents:     Class KairosAboutDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Diagnostics;

namespace Kairos.Library.Gui
{
	public partial class KairosAboutDialog : Form
	{
		private const string URL = "http://www.pikkatech.eu";
		public KairosAboutDialog()
		{
			InitializeComponent();
		}

		private void OnPikkatechLinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				ProcessStartInfo sInfo = new ProcessStartInfo(URL);
				sInfo.UseShellExecute = true;
				Process.Start(sInfo);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
	}
}
