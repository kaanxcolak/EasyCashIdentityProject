using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    [Authorize]
    public class MyAccountsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
