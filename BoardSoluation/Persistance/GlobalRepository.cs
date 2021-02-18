using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoardSoluation.Core;
using BoardSoluation.Data;
using BoardSoluation.Models;

namespace BoardSoluation.Persistance
{
	public class GlobalRepository : IGlobalRepository
	{
		private  ApplicationDbContext _context { get; set; }
		public GlobalRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public IList<Division> GetAllDivisions()
		{
			return _context.Divisions.ToList();
		}

		public IList<District> GetAllDistricts()
		{
			return _context.Districts.ToList();
		}

		public IList<School> GetAllSchools()
		{
			return _context.Schools.ToList();
		}

		public IList<Department> GetAllDepartments()
		{
			return _context.Departments.ToList();
		}
	}
}
