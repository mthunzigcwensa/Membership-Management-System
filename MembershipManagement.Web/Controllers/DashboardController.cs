using Microsoft.AspNetCore.Mvc;

namespace MembershipManagement.Web.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
