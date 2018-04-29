using BilgeAdam.Northwind.NetData.Dtos;
using BilgeAdam.Northwind.NetData.Repositories;
using System.Web.Mvc;

namespace BilgeAdam.Northwind.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductRepository repo;
        public ProductController()
        {
            repo = new ProductRepository();
        }
        public ActionResult Index()
        {
            var products = repo.GetAvailableProducts();
            return View(products);
        }

        public ActionResult NewProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveProduct(ProductDto product)
        {
            repo.SaveProduct(product);
            return RedirectToAction(nameof(Index));
        }
    }
}