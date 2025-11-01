/***********************************************************************************
* File:         Activity.cs                                                        *
* Contents:     Class Activity                                                     *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-30 17:34                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Kairos.Library.Entities
{
	public class Activity
	{
		public int Id	{get;set;} = 0;
		public string Name	{get;set;} = "";
		public string Description	{get;set;} = "";

		public List<WorkInterval> WorkIntervals	{get; set;} = new List<WorkInterval>();

		/// <summary>
		/// Computes time for the activity since today's begin.
		/// </summary>
		/// <returns></returns>
		public TimeSpan GetTodaysTime()
		{
			DateTime dayStart	= DateTime.Today;
			DateTime dayEnd		= DateTime.Today.AddDays(1);
			double y = this.WorkIntervals.Where(ti => ti.Start >= dayStart && ti.End <= dayEnd).Sum(x => x.Duration.TotalSeconds);

			TimeSpan result = TimeSpan.FromSeconds(y);

			return result;
		}

		public TimeSpan GetThisWeeksTime()
		{
			DateTime monday = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + (int)DayOfWeek.Monday);

			DateTime dayEnd		= DateTime.Today.AddDays(1);
			double y = this.WorkIntervals.Where(ti => ti.Start >= monday && ti.End <= dayEnd).Sum(x => x.Duration.TotalSeconds);

			TimeSpan result = TimeSpan.FromSeconds(y);

			return result;
		}

		public TimeSpan GetAllTime()
		{
			double y = this.WorkIntervals.Sum(x => x.Duration.TotalSeconds);

			TimeSpan result = TimeSpan.FromSeconds(y);

			return result;
		}
	}
}
