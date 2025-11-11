/***********************************************************************************
* File:         Project.cs                                               *
* Contents:     Class Project                                            *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-30 17:33                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json;

namespace Kairos.Library.Entities
{
	public class Project
	{
		public string Name	{get;set;} = "";
		public string Description	{get;set;} = "";
		public DateTime Created	{get; set;} = DateTime.Now;

		public List<Component> Components	{get; set;} = new List<Component>();

		public void Save(string path)
		{
			string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			File.WriteAllText(path, json);
		}

		public static Project Load(string path)
		{
			if (!File.Exists(path))
			{
				return new Project();
			}

			string json = File.ReadAllText(path);

			return JsonSerializer.Deserialize<Project>(json) ?? new Project();
		}

		#region Construction
		public Project()
		{

		}

		public Project(Project project)
		{
			this.Name			= project.Name;
			this.Description	= project.Description;
			this.Created		= project.Created;

			foreach (Component component in project.Components)
			{
				this.Components.Add(new Component(component));
			}
		}
		#endregion
	}
}
