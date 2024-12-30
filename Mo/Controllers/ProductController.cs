using Microsoft.AspNetCore.Mvc;
using Mo.Data;
using Mo.Models;

namespace Mo.Controllers
{
	public class ProductController : Controller
	{
		Db_Context context = new Db_Context();
		Product Product = new Product();
		public IActionResult Index()
		{
			var view = context.Products.ToList();
			return View(view);
		}


		public IActionResult Create()
		{
			return View();
		}
		[HttpPost]
		public IActionResult Create(Product product)
		{
			context.Products.Add(product);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		public IActionResult Delete(int id)
		{
			var delete = context.Products.Find(id);
			context.Products.Remove(delete);
			context.SaveChanges();
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Update(int id )
		{
			var update = context.Products.Find(id);
			return View(update);
		}

		[HttpPost]
		public IActionResult Update(int id , Product product)
		{
			var update = context.Products.Find(id);
			update.price = product.price;
			update.description = product.description;
			context.SaveChanges();
			return RedirectToAction("Index");
		}
	}
}
