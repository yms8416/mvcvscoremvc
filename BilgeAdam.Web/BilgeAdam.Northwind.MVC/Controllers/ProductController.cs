using BilgeAdam.Northwind.NetData.Repositories;
using System.Web.Mvc;

namespace BilgeAdam.Northwind.MVC.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            var repo = new ProductRepository();
            var products = repo.GetAvailableProducts();
            return View(products);
        }
    }
}