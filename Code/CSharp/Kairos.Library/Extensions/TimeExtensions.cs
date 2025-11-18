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

		public static string Formatted(this TimeSpan time)
		{
			int hours = (int)(time.TotalDays * 24 + time.Hours);

			return $"{hours}:{time.Minutes}:{time.Seconds}";
		}

		public static double WorkingDays(this TimeSpan time, double workingHoursInDay, int decimals = 2)
		{
			double hours = time.TotalDays * 24 + time.Hours + time.Minutes / 60;

			return Math.Round(hours / workingHoursInDay, decimals);
		}
	}
}
