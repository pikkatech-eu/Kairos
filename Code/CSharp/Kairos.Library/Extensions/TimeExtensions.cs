/***********************************************************************************
* File:         TimeExtensions.cs                                                  *
* Contents:     Class TimeExtensions                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-29 22:39                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Kairos.Library.Extensions
{
	public static class TimeExtensions
	{
		public static TimeSpan StripMilliseconds(this TimeSpan time)
		{
			return new TimeSpan(time.Days, time.Hours, time.Minutes, time.Seconds);
		}
	}
}
