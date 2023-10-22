using Laboratorium_2.Models;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_2.Controllers
{
    public class BirthController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Form()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result([FromForm] Birth model)
        {
            if (ModelState.IsValid)
            {
                if (model.IsValid())
                {
                    int age = model.CalculateAge();
                   
                    ViewBag.Age = age; 
                    return View(model);
                }
                else
                {
                    ModelState.AddModelError("", "Formularz jest niepoprawny.");
                }
            }
            return View("Form", model); 
        }
    }
       
    
}
