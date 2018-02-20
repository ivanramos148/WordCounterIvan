using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
      public ActionResult Index()
      {
        string emptyField = "";
        return View("Index", emptyField);
      }

      [HttpPost("/result")]
      public ActionResult Result()
      {
        string findWord = Request.Form["compareword"];
        string inputPhrase = Request.Form["inputsetence"];
        Words newWordCount = new Words(inputPhrase, findWord);
        int displayCount = newWordCount.RepeatCounter();
        return View("Index", displayCount);
      }
    }
  }
