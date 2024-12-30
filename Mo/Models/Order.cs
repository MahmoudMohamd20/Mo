using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Mo.Models
{
	public class Order
	{
		[Key]
		public int Id { get; set; }
		public int total { get; set; }

		[ForeignKey("CustomerID")]
		public int CustomerID { get; set; }
		public Customer Customer { get; set; }
		[ForeignKey("ProductID")]
		public int ProductID { get; set; }
		public Product Product { get; set; }

	}
}
