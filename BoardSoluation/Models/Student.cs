namespace BoardSoluation.Models
{
	public class Student
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public School School { get; set; }
		public Department Department { get; set; }
		public District District { get; set; }
		public Division Division { get; set; }
	}
}