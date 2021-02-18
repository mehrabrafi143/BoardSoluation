using System.Collections.Generic;

namespace BoardSoluation.Models
{
	public class Department
	{
		public int Id { get; set; }
		public string DeptName { get; set; }
		public List<Student> Students { get; set; }

		public Department()
		{
			Students = new List<Student>();
		}
	}
}