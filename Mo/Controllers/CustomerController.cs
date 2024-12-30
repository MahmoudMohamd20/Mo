using Microsoft.AspNetCore.Mvc;
using Mo.Data;
using Mo.Models;

namespace Mo.Controllers
{
	public class CustomerController : Controller
	{
		Db_Context context = new Db_Context();
		Customer cost = new Customer();

		public IActionResult Index()
		{
			var view = context.Customers.ToList();
			return View(view);
		}



		[HttpPost]
		public IActionResult Create(Customer customer)
		{
			context.Customers.Add(customer);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Delete(int id )
		{
			var delete = context.Customers.Find(id);
			context.Customers.Remove(delete);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		[HttpGet]
		public IActionResult Update(int id )
		{
			var update = context.Customers.Find( id );
		
			return View(update);
		}

		[HttpPost]
		public IActionResult Update(int id ,  Customer customer)
		{
			var upated = context.Customers.FirstOrDefault(customer => customer.Id == id);
			upated.name = customer.name;
			upated.age = customer.age;
			context.SaveChanges();
			return RedirectToAction("Index");
		}

	}
}
