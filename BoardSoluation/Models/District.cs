using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardSoluation.Models
{
	public class District
	{
		public int Id { get; set; }
		public string DistrictName { get; set; }
		public Division Division { get; set; }
		[ForeignKey("Division")]
		public int DivisionId { get; set; }

		public List<School> Schools { get; set; }

		public District()
		{
			Schools = new List<School>();
		}
	}
}