using Microsoft.AspNetCore.Mvc;

namespace MembershipManagement.Web.Controllers
{
    public class DashboardsController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
