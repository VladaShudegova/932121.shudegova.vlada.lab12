using Lab12.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab12.Controllers;

public class ModelBindingSeparateModelController : Controller
{
  [HttpGet]
  public IActionResult Index() => View();

  [HttpPost]
  public IActionResult Result(NumberModel model)
  {
    String result = model.Operation switch
    {
        "+" => (model.FirstNum + model.SecondNum).ToString(),
        "-" => (model.FirstNum - model.SecondNum).ToString(),
        "/" => ((model.SecondNum != 0) ? (model.FirstNum / model.SecondNum).ToString() : "Деление на ноль невозможно"),
        "*" => (model.FirstNum * model.SecondNum).ToString(),
    };
    ViewData["result"] = result;
    return View(model);
  }
}