using Microsoft.AspNetCore.Mvc;

namespace AppPrivy.WebAppSiteBlog.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
