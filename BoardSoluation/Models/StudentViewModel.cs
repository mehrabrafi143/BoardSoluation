using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BoardSoluation.Models
{
	public class StudentViewModel
	{
		public int? Id { get; set; }
		public string Email { get; set; }
		public IList<School> Schools { get; set; }
		public IList<Department> Departments { get; set; }
		public IList<Division> Divisions { get; set; }
		public IList<District> Districts { get; set; }
		public int SchoolId { get; set; }
		public int DistrictId { get; set; }
		public int DepartmentId { get; set; }
		public int DivisionId { get; set; }

		public StudentViewModel()
		{
			Schools = new List<School>();
			Departments = new List<Department>();
			Divisions = new List<Division>();
			Districts = new List<District>();
		}
	}
}
