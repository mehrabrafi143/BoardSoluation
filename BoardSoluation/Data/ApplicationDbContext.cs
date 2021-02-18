using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using BoardSoluation.Models;

namespace BoardSoluation.Data
{
	public class ApplicationDbContext : IdentityDbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
			: base(options)
		{

		}

		public DbSet<Division> Divisions { get; set; }
		public DbSet<District> Districts { get; set; }
		public DbSet<School> Schools { get; set; }
		public DbSet<Department> Departments { get; set; }
		public DbSet<Student> Students { get; set; }
	}
}
