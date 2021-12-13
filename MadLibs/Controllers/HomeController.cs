using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    public string Hello() { return "Hello friend!"; }

    [Route("/")]
    public ActionResult Story()
    {
      StoryVariable myLetterVariable = new StoryVariable();
      myLetterVariable.Name = "__Name__";
      myLetterVariable.Person1 = "__Celebrity__";
      myLetterVariable.Person2 = "__Celebrity2__";
      myLetterVariable.Animal = "__Animal__";
      myLetterVariable.Exclamation = "__Exclamation__";
      myLetterVariable.Verb = "__Verb__";
      myLetterVariable.Noun = "__Noun__";
      return View(myLetterVariable);
    }

    [Route("/form")]
    public ActionResult Form() { return View(); }

    [Route("/filledstory")]
    public ActionResult Filledstory(string name, string noun, string verb, string person1, string person2, string exclamation, string animal)
    {
      StoryVariable myLetterVariable = new StoryVariable();
      myLetterVariable.Name = name;
      myLetterVariable.Noun = noun;
      myLetterVariable.Verb = verb;
      myLetterVariable.Person1 = person1;
      myLetterVariable.Person2 = person2;
      myLetterVariable.Animal = animal;
      myLetterVariable.Exclamation = exclamation;
      return View(myLetterVariable);
    }
  }
}