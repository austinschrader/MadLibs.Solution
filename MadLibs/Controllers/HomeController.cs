using Microsoft.AspNetCore.Mvc;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend"; }

    [Route("/goodbye")]
    public string GoodBye() { return "Goodbye!"; }

    [Route("/")]
    public string Letter() { return "Our MadLib will go here..."; }
  }
}