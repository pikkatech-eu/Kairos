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
	}
}
