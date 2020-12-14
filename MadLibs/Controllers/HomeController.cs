using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    [Route("/hello")]
    public string Hello() { return "Hello friend"; }

    [Route("/")]
    public ActionResult Form() { return View(); }

    [Route("/body")]
    public ActionResult Body(string person1, string person2, string animal, string exclamation, string personal, string verb, string noun) 
    {
      BodyVariable myBodyVariable = new BodyVariable();
      myBodyVariable.Person1 = person1;
      myBodyVariable.Person2 = person2;
      myBodyVariable.Animal = animal;
      myBodyVariable.Exclamation = exclamation;
      myBodyVariable.Personal = personal;
      myBodyVariable.Verb = verb;
      myBodyVariable.Noun = noun;
      return View(myBodyVariable); 
    }
  }
}