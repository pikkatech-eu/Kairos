/***********************************************************************************
* File:         Project.cs                                                         *
* Contents:     Class Project                                                      *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-30 17:33                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

namespace Kairos.Library.Entities
{
	public class Project
	{
		public int Id	{get;set;} = 0;
		public string Name	{get;set;} = "";
		public string Description	{get;set;} = "";

		public List<Activity> Activities	{get; set;} = new List<Activity>();

		/// <summary>
		/// Computes time for the project since today's begin.
		/// </summary>
		/// <returns></returns>
		public TimeSpan GetTodaysTime()
		{
			double y = this.Activities.Sum(ac => ac.GetTodaysTime().TotalSeconds);

			return TimeSpan.FromSeconds(y);
		}

		public TimeSpan GetThisWeeksTime()
		{
			double y = this.Activities.Sum(ac => ac.GetThisWeeksTime().TotalSeconds);

			return TimeSpan.FromSeconds(y);
		}

		public TimeSpan GetAllTime()
		{
			double y = this.Activities.Sum(ac => ac.GetAllTime().TotalSeconds);

			return TimeSpan.FromSeconds(y);
		}
	}
}
