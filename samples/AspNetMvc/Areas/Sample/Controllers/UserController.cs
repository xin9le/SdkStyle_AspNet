using System.Web.Mvc;

namespace AspNetMvc.Areas.Sample.Controllers
{
    public class UserController : Controller
    {
        // GET: Sample/User
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Info()
        {
            return View();
        }
    }
}
