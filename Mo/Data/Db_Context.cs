using Microsoft.EntityFrameworkCore;
using Mo.Models;

namespace Mo.Data
{
	public class Db_Context : DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=Modyy;Integrated Security=True;Encrypt=False;TrustServerCertificate=True");
		}
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<Order> Orders { get; set; }
	}
}
