/***********************************************************************************
* File:         StorageService.cs                                                  *
* Contents:     Class StorageService                                               *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-28 22:14                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Kairos.Library.Entities;

namespace Kairos.Library
{
	public class StorageService
	{
		private readonly string _filePath;

		public StorageService(string filePath)
		{
			_filePath = filePath;
		}

		public List<WorkInterval> Load()
		{
			if (!File.Exists(_filePath))
			{
				return new List<WorkInterval>();
			}
				

			string json = File.ReadAllText(_filePath);
			return JsonSerializer.Deserialize<List<WorkInterval>>(json) ?? new List<WorkInterval>();
		}

		public void Save(List<WorkInterval> intervals)
		{
			string json = JsonSerializer.Serialize(intervals, new JsonSerializerOptions { WriteIndented = true });
			File.WriteAllText(_filePath, json);
		}
	}
}
