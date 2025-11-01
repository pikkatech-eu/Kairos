/***********************************************************************************
* File:         Fixture.cs                                               *
* Contents:     Class Fixture                                            *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-30 17:33                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System.Text.Json;

namespace Kairos.Library.Entities
{
	public class Fixture
	{
		public string Name	{get;set;} = "";
		public string Description	{get;set;} = "";
		public DateTime Created	{get; set;} = DateTime.Now;

		public List<Component> Projects	{get; set;} = new List<Component>();

		public void Save(string path)
		{
			string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
			File.WriteAllText(path, json);
		}

		public static Fixture Load(string path)
		{
			if (!File.Exists(path))
			{
				return new Fixture();
			}

			string json = File.ReadAllText(path);

			return JsonSerializer.Deserialize<Fixture>(json) ?? new Fixture();
		}
	}
}
