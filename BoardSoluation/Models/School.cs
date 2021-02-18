using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoardSoluation.Models
{
	public class School
	{
		public int Id { get; set; }
		public string SchoolName { get; set; }
		public District District { get; set; }
		[ForeignKey("District")]
		public int DistrictId { get; set; }

		public List<Student> Students { get; set; }

		public School()
		{
			Students = new List<Student>();
		}
	}
}