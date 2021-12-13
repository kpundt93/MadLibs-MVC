using Microsoft.AspNetCore.Mvc;
using MadLibs.Models;

namespace MadLibs.Controllers
{
  public class HomeController : Controller
  {
    public string Hello() { return "Hello friend!"; }

    [Route("/")]
    public ActionResult Homepage()
    {
      return View();
    }

    [Route("/puppyForm")]
    public ActionResult PuppyForm() { return View();}

    [Route("/puppyStory")]
    public ActionResult PuppyStory(string name, string noun, string verb, string bark)
    {
      PuppyVariable myPuppyVariable= new PuppyVariable();
      myPuppyVariable.Name = name;
      myPuppyVariable.Noun = noun;
      myPuppyVariable.Verb = verb;
      myPuppyVariable.Bark = bark;
      return View(myPuppyVariable);
    }

    [Route("/celebForm")]
    public ActionResult CelebForm() { return View(); }

    [Route("/celebStory")]
    public ActionResult CelebStory(string name, string noun, string verb, string person1, string person2, string exclamation, string animal)
    {
      CelebVariable myLetterVariable = new CelebVariable();
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