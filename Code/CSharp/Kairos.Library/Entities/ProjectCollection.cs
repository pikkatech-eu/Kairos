using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Kairos.Library.Entities
{
	public class ProjectCollection
	{
		public string Name	{get;set;} = "";
		public string Description	{get;set;} = "";
		public DateTime Created	{get;internal set;} = DateTime.Now;

		public List<Project> Projects	{get;internal set;} = new List<Project>();

		public void Save(string path)
		{
			string json = JsonSerializer.Serialize(this.Projects, new JsonSerializerOptions { WriteIndented = true });
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
