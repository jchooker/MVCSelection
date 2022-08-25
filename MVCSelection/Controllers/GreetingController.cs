using Microsoft.AspNetCore.Mvc;

namespace MVCSelection.Controllers
{
    public class GreetingController : Controller
    {
        public string Index()
        {
            return "Welcome to the index page";
        }

        public string Hello()
        {
            return "Who is there?";
        }
    }

}
