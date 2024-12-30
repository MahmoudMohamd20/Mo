using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Mo.Data;
using Mo.Models;

namespace Mo.Controllers
{
	public class OrderController : Controller
	{
		Db_Context context = new Db_Context();
		Order order = new Order();

		public IActionResult Index()
		{
			var view = context.Orders.ToList();
			return View(view);
		}
		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Order oder)
		{
			context.Orders.Add(oder);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Delete(int id )
		{
			var delete = context.Orders.Find(id);
			context.Orders.Remove(delete);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Update(int id )
		{
			var update = context.Orders.Find(id);
			return View(update);
		}
		[HttpPost]
		public IActionResult Update(int id , Order oder)
		{
			var update = context.Orders.Find(id);
			update.total = oder.total;
			update.CustomerID = oder.CustomerID;
			update.ProductID = oder.ProductID;
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		public IActionResult ViewForm(int id )
		{
			var show = context.Orders.Include(x => x.Customer).Include(x => x.Product).FirstOrDefault(x=>x.Id==id);
			if (show == null)
			{
				return NotFound();
			}
			return View(show);
		}

	}
}
