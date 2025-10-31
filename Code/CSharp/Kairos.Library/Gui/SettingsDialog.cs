/***********************************************************************************
* File:         SettingsDialog.cs                                                  *
* Contents:     Class SettingsDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using Kairos.Library;

namespace BugLite.Library.Gui.Dialogs
{
	public partial class SettingsDialog : Form
	{
		public SettingsDialog()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public Settings Settings
		{
			get
			{
				return this._pgSettings.SelectedObject as Settings;
			}

			set
			{
				this._pgSettings.SelectedObject = value;
			}
		}
	}
}
