using System.Web.Mvc;

namespace Comtex.Skyknight.Web.Controllers
{
    public class HomeController : ControllerBase
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

    }
}
