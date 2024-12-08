using Lab12.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab12.Controllers;

public class ModelBindingParametersController : Controller
{
  [HttpGet]
  public IActionResult Index() => View();

  [HttpPost]
  public IActionResult Result(int firstNumber, String operation, int secondNumber)
  {
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