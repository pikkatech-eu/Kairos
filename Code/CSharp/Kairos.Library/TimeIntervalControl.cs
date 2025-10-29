/***********************************************************************************
* File:         TimeIntervalControl.cs                                             *
* Contents:     Class TimeIntervalControl                                          *
* Author:       Stanislav Koncebovski (stanislav@pikkatech.eu)                     *
* Date:         2022-03-15 15:14                                                   *
* Version:      1.0                                                                *
* Copyright:    prefero labs (www.prefero.chimgan.net)                             *
***********************************************************************************/
using System.Windows.Forms;
using System.ComponentModel;

namespace Kairos.Library
{
	public partial class TimeIntervalControl : UserControl
	{
		public TimeIntervalControl()
		{
			InitializeComponent();
		}

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public int Milliseconds
		{
			get
			{
				return (int)(60 * this._nudMinute.Value + this._nudSecond.Value) * 1000;
			}

			set
			{
				int seconds = value / 1000;
				int minutes = seconds / 60;
				seconds -= minutes * 60;

				this._nudMinute.Value	= minutes;
				this._nudSecond.Value = seconds;
			}
		}
	}
}
