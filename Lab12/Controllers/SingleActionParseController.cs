using Microsoft.AspNetCore.Mvc;

namespace Lab12.Controllers;

public class SingleActionParseController : Controller
{
  public IActionResult Index()
  {
    if (Request.Method == "GET")
    {
      return View();
    }

    int firstNumber = int.Parse(Request.Form["firstNumber"]);
    int secondNumber = int.Parse(Request.Form["secondNumber"]);
    String operation = Request.Form["operation"];
      
    String result = operation switch
    {
        "+" => (firstNumber + secondNumber).ToString(),
        "-" => (firstNumber - secondNumber).ToString(),
        "/" => ((secondNumber != 0) ? (firstNumber / secondNumber).ToString() : "Деление на ноль невозможно"),
        "*" => (firstNumber * secondNumber).ToString(),
    };
    FormViewData(firstNumber,  operation, secondNumber, result);

    return View();
  }
  
  [NonAction]
  private void FormViewData(int firstNumber, String operation, int secondNumber, String result)
  {
    ViewData["firstNumber"] = firstNumber;
    ViewData["operation"] = operation;
    ViewData["secondNumber"] = secondNumber;
    ViewData["result"] = result;
  }
}