using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GameStore.Domain.Abstract;

namespace GameStore.WebUI.Controllers
{
    /// <summary>
    /// button controller
    /// </summary>
    public class NavController : Controller
    {
        private IGameRepository repository;
        public NavController(IGameRepository repo)
        {
            repository = repo;
        }

        /// <summary>
        /// load navigation
        /// </summary>
        /// <param name="category"></param>
        /// <returns></returns>
        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;
            IEnumerable<string> categories = repository.Games
                .Select(game => game.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView("FlexMenu", categories);
        }
    }
}
