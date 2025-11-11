/***********************************************************************************
* File:         WorkInterval.cs                                                    *
* Contents:     Class WorkInterval                                                 *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-30 17:34                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json.Serialization;
using Kairos.Library.Extensions;

namespace Kairos.Library.Entities
{
	public class WorkInterval
	{
		#region Properties
		public Guid			Id			{get;set;} = Guid.NewGuid();
		public DateTime		Start		{get;set;}
		public DateTime?	End			{get;set;}
		public string?		Description	{get;set;}

		[JsonIgnore]
		public TimeSpan Duration => (End ?? DateTime.Now) - Start;

		public string[] ListViewStrings()
		{
			return 
					[
						this.Start.ToString(), 
						this.End != null ? this.End.ToString() : DateTime.Now.ToString(), 
						this.Duration.StripMilliseconds().ToString(), 
						this.Description
					];
		}

		public override string ToString() => $"{Start:g} - {End?.ToString("g") ?? "…"} ({Description})";
		#endregion

		#region Construction
		public WorkInterval()
		{
		}

		public WorkInterval(Guid guid, DateTime start, DateTime? end, string? description)
		{
			this.Id				= guid;
			this.Start			= start;
			this.End			= end;
			this.Description	= description;
		}

		public WorkInterval(WorkInterval wi) : this(wi.Id, wi.Start, wi.End, wi.Description)	{}
		#endregion
	}
}
