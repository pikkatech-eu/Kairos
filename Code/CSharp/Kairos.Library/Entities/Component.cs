/***********************************************************************************
* File:         Component.cs                                                       *
* Contents:     Class Component                                                    *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-30 17:33                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Diagnostics;

namespace Kairos.Library.Entities
{
	public class Component
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

		#region Construction
		public Component()
		{

		}

		public Component(Component component)
		{
			this.Id				= component.Id;
			this.Name			= component.Name;
			this.Description	= component.Description;

			foreach (Activity activity in component.Activities)
			{
				this.Activities.Add(new Activity(activity));
			}
		}
		#endregion
	}
}
