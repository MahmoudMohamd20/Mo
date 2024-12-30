using System.ComponentModel.DataAnnotations;

namespace Mo.Models
{
	public class Customer
	{
		[Key]
		public int Id { get; set; }

		[Required(ErrorMessage ="Please Enter your name ") ,MaxLength(50)]
		public string name { get; set; }

		public int age { get; set; }


	}
}
