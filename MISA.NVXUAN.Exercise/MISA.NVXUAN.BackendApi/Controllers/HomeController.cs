using Microsoft.AspNetCore.Mvc;

namespace MISA.NVXUAN.BackendApi.Controllers
{
    [Route("[controller]")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
