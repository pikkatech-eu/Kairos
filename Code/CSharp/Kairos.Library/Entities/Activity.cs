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
	}
}
