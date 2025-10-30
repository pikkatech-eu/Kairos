/***********************************************************************************
* File:         ProjectCollection.cs                                               *
* Contents:     Class ProjectCollection                                            *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-30 17:33                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json;

namespace Kairos.Library.Entities
{
	public class ProjectCollection
	{
		public string Name	{get;set;} = "";
		public string Description	{get;set;} = "";
		public DateTime Created	{get; set;} = DateTime.Now;

		public List<Project> Projects	{get; set;} = new List<Project>();

		public void Save(string path)
		{
			string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			File.WriteAllText(path, json);
		}

		public static ProjectCollection Load(string path)
		{
			if (!File.Exists(path))
			{
				return new ProjectCollection();
			}

			string json = File.ReadAllText(path);

			return JsonSerializer.Deserialize<ProjectCollection>(json) ?? new ProjectCollection();
		}
	}
}
