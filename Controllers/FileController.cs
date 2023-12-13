using Microsoft.AspNetCore.Mvc;

namespace CloudApp.Controllers
{
    public class FileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
