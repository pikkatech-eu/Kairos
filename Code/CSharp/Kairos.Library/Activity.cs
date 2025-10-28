using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kairos.Library
{
	public class Activity
	{
		public int Id	{get;set;} = 0;
		public string Name	{get;set;} = "";
		public string Description	{get;set;} = "";

		public List<WorkInterval> WorkIntervals	{get;internal set;} = new List<WorkInterval>();
	}
}
