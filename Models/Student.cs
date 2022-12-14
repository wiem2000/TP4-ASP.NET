using System.ComponentModel.DataAnnotations;

namespace tp4asp.Models
{
    public class Student
    {
		[Key]
		public int id { get; set; }

		public string? first_name { get; set; }
		public string? last_name { get; set; }
		public string? phone_number { get; set; }
		public string? university { get; set; }
		public string? course { get; set; }
		public string? timestamp { get; set; }
	}
}
