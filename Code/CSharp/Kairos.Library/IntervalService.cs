/***********************************************************************************
* File:         IntervalService.cs                                                 *
* Contents:     Class IntervalService                                              *
* Author:       Stanislav "Bav" Koncebovski (stanislav@pikkatech.eu)               *
* Date:         2025-10-28 22:16                                                   *
* Version:      1.0                                                                *
* Copyright:    pikkatech.eu (www.pikkatech.eu)                                    *
***********************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kairos.Library.Entities;

namespace Kairos.Library
{
	public class IntervalService
	{
		private readonly StorageService _storage;
		private List<WorkInterval> _intervals;

		public IntervalService(StorageService storage)
		{
			_storage = storage;
			_intervals = storage.Load();
		}

		public IEnumerable<WorkInterval> GetAll() => _intervals.OrderByDescending(i => i.Start);

		public void StartInterval(string? description = null)
		{
			var active = _intervals.FirstOrDefault(i => i.End == null);
			if (active != null)
			{
				throw new InvalidOperationException("There’s already an active interval.");
			}

			_intervals.Add(new WorkInterval { Start = DateTime.Now, Description = description });
			_storage.Save(_intervals);
		}

		public void StopInterval()
		{
			var active = _intervals.FirstOrDefault(i => i.End == null);
			if (active == null)
			{
				throw new InvalidOperationException("No active interval to stop.");
			}

			active.End = DateTime.Now;
			_storage.Save(_intervals);
		}
	}
}
