using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Kairos.Library
{
	public class WorkInterval
	{
		#region Properties
		public Guid Id { get; set; } = Guid.NewGuid();
		public DateTime Start { get; set; }
		public DateTime? End { get; set; }
		public string? Description { get; set; }

		[JsonIgnore]
		public TimeSpan Duration => (End ?? DateTime.Now) - Start;

		public override string ToString() =>
			$"{Start:g} - {(End?.ToString("g") ?? "…")} ({Description})";
		#endregion
	}
}
