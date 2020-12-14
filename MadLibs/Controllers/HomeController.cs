using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend"; }

    [Route("/goodbye")]
    public string GoodBye() { return "Goodbye!"; }

    [Route("/")]
    public ActionResult Body() 
    {
      BodyVariable myBodyVariable = new BodyVariable();
      myBodyVariable.Person1 = "Jeff";
      myBodyVariable.Person2 = "Jeff";
      myBodyVariable.Animal = "Jeff";
      myBodyVariable.Exclamation = "Jeff";
      myBodyVariable.Personal = "Jeff";
      myBodyVariable.Verb = "Jeff";
      myBodyVariable.Noun = "Jeff";
      return View(myBodyVariable); 
    }
  }
}