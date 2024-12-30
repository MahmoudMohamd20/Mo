using System.ComponentModel.DataAnnotations;

namespace Mo.Models
{
	public class Product
	{
		[Key]
		public int Id { get; set; }
		public string description { get; set; }
		public int price { get; set; }
	}
}
