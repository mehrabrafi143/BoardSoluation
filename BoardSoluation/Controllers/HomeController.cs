using BoardSoluation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BoardSoluation.Data;
using BoardSoluation.Persistance;
using Microsoft.EntityFrameworkCore;

namespace BoardSoluation.Controllers
{
	public class HomeController : Controller
	{

		private readonly ApplicationDbContext _context;
		public HomeController(ApplicationDbContext context)
		{
			_context = context;
		}

		public IActionResult Index()
		{
			StudentViewModel viewModel = new StudentViewModel
			{
				Divisions = _context.Divisions.ToList(),
				Districts = _context.Districts.ToList(),
				Schools = _context.Schools.ToList(),
				Departments = _context.Departments.ToList()
			};

			return View(viewModel);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

		public IActionResult Save(StudentViewModel studentViewModel)
		{
			Student student = new Student
			{
				Email = studentViewModel.Email,
				Department = _context.Departments.SingleOrDefault(p => p.Id == studentViewModel.DepartmentId),
				District = _context.Districts.SingleOrDefault(d => d.Id == studentViewModel.DistrictId),
				School = _context.Schools.SingleOrDefault(s => s.Id == studentViewModel.SchoolId),
				Division = _context.Divisions.SingleOrDefault(d => d.Id == studentViewModel.DivisionId)
			};
			_context.Students.Add(student);
			_context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult Info()
		{
			List<Division> info = _context.Divisions.Include(d => d.Districts)
				.ThenInclude(p => p.Schools)
				.ThenInclude(o => o.Students)
				.ThenInclude(p => p.Department)
				.ToList();


			return View(info);
		}
	}

}
