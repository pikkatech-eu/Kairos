/***********************************************************************************
* File:         KairosAboutDialog.cs                                                  *
* Contents:     Class KairosAboutDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Diagnostics;
using FV = Factotum.Versioning;

namespace Kairos.Library.Gui
{
	public partial class KairosAboutDialog : Form
	{
		private const string URL = "http://www.pikkatech.eu";
		public KairosAboutDialog()
		{
			InitializeComponent();

			FV.Version version = new FV.Version();
			version.FromToml();

			this._txVersion.Text =  $"Kairos {version}";
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
