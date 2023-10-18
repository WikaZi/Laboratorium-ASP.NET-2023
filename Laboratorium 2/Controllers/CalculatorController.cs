using Laboratorium_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2.Controllers
{
    public enum Operators
    {
        ADD, SUB, MUL, DIV
    }
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
       
        //public IActionResult Result([FromQuery(Name = "operator")] Operators op, double? x, double? y)
        //{

        //    {
        //        if (op == null || x == null || y == null)
        //        {
        //            return View("Error");
        //        }
        //        string result = " ";
        //        switch (op)
        //        {
        //            case Operators.ADD:
        //                result = $"{x} + {y} = {x + y}";
        //                break;
        //            case Operators.SUB:
        //                result = $"{x} + {y} = {x + y}";
        //                break;
        //            case Operators.MUL:
        //                result = $"{x} + {y} = {x + y}";
        //                break;
        //            case Operators.DIV:
        //                result = $"{x} + {y} = {x + y}";
        //                break;

        //        }
        //        ViewBag.Result = result;
        //        return View();
        //    }

        //}
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result(Calculator model)
        {
            if (!model.IsValid())
            {
                return View("Error");
            }
            return View(model);
        }
    }

}
