using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GameStore.Domain.Abstract;


namespace GameStore.WebUI.Controllers
{
    public class HomeController: Controller
    {
        
        public ActionResult Index()
        {
            return View();
        }

    }
}