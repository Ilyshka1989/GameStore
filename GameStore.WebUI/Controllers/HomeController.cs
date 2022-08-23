using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using GameStore.Domain.Abstract;


namespace GameStore.WebUI.Controllers
{
    public class HomeController: Controller
    {
        private IGameRepository repository;
        public HomeController(IGameRepository repo)
        {
            repository = repo;
        }

        public PartialViewResult Menu(string category = null)
        {
            ViewBag.SelectedCategory = category;

            IEnumerable<string> categories = repository.Games
                .Select(game => game.Category)
                .Distinct()
                .OrderBy(x => x);
            return PartialView(categories);
        }
    }
}