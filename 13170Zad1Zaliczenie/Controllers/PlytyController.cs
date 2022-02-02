using _13170Zad1Zaliczenie.Models;
using Microsoft.AspNetCore.Mvc;

namespace _13170Zad1Zaliczenie.Controllers
{
    public class PlytyController : Controller
    {
        private static List<PlytyMeblowe> items = new List<PlytyMeblowe>
        {
            new PlytyMeblowe() { Szerokosc = 100, Wysokosc = 10, Cena = 50, Ilosc = 2, Suma = 100, Powierzchnia = 1000 }
        };
        public IActionResult Index()
        {
            return View(items);
        }

        public IActionResult Create()
        {
            return View("Create");
        }
        [HttpPost]

        public IActionResult Create(PlytyMeblowe item)
        {
            item.Suma = item.Cena * item.Ilosc;
            item.Powierzchnia = item.Szerokosc * item.Wysokosc;
            items.Add(item);
            return RedirectToAction("Index");
        }
    }
}
