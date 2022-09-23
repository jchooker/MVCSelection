using Microsoft.AspNetCore.Mvc;
using MVCSelection.Models;

namespace MVCSelection.Controllers
{
    public class GreetingController : Controller
    {
        public IActionResult Index()
        {
            DogViewModel dog = new DogViewModel() { Name = "Zambie", Age = 8 };
            return View(dog);
        }

        public IActionResult Create()
        {
            var dogVm = new DogViewModel();
            return View(dogVm);
        }

        public IActionResult CreateDog(DogViewModel dogViewModel)
        {
            return View("Index");
        }
        public string Hello()
        {
            return "Who is there?";
        }
    }

}
