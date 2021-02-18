using System.Collections.Generic;

namespace BoardSoluation.Models
{
	public class Division
	{
		public int Id { get; set; }
		public string DivisionName { get; set; }
		public List<District> Districts { get; set; }
		public Division()
		{
			Districts = new List<District>();
		}
	}
}
