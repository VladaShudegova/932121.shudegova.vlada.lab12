using Microsoft.AspNetCore.Mvc;

namespace Lab12.Models;

public class NumberModel
{
  [BindProperty(Name = "firstNumber")]
  public int FirstNum { get; set; }
  
  [BindProperty(Name = "operation")]
  public String Operation { get; set; }
  
  [BindProperty(Name = "secondNumber")]
  public int SecondNum { get; set; }
}