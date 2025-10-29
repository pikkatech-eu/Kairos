using System.Text.Json.Serialization;
using Kairos.Library.Extensions;

namespace Kairos.Library.Entities
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

		public string[] ListViewStrings()
		{
			//TimeSpan ts = this.Duration;
			//ts = ts.Add(new TimeSpan(0, 0, 1));

			//int hours   = ts.Hours;
			//int minutes = ts.Minutes;
			//int seconds = ts.Seconds;

			return 
					[
						this.Start.ToString(), 
						this.End != null ? this.End.ToString() : DateTime.Now.ToString(), 
						this.Duration.StripMilliseconds().ToString(), 
						this.Description
					];
		}

		public override string ToString() =>
			$"{Start:g} - {End?.ToString("g") ?? "…"} ({Description})";
		#endregion
	}
}
