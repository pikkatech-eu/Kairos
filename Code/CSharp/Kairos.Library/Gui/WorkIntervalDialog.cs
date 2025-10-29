/***********************************************************************************
* File:         WorkIntervalDialog.cs                                                  *
* Contents:     Class WorkIntervalDialog                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2024-11-06 15:55                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.ComponentModel;
using Kairos.Library.Entities;

namespace Kairos.Library.Gui
{
	public partial class WorkIntervalDialog : Form
	{
		public WorkIntervalDialog()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public WorkInterval	WorkInterval
		{
			get
			{
				WorkInterval workInterval	= new WorkInterval();
				workInterval.Start			= this._dtpFrom.Value;
				workInterval.End			= this._dtpTo.Value;

				workInterval.Description	= this._txDescription.Text;

				return workInterval;
			}

			set
			{
				this._dtpFrom.Value			= value.Start;
				this._dtpTo.Value			= value.End ?? DateTime.Now;
				this._txDescription.Text	= value.Description;
			}
		}
	}
}
