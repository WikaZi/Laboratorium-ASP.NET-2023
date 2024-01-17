using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Laboratorium_3___App.Controllers
{
    [Authorize(Roles = "admin")]
    public class ComputerController : Controller
    {
        private readonly IComputerService _computerService;
        public ComputerController(IComputerService computerService)
        {
            _computerService = computerService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_computerService.FindAll());
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Computer model) 
        {
            if (ModelState.IsValid)
            {
                _computerService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
            
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_computerService.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Computer model)
        {
            if(ModelState.IsValid)
            {
                _computerService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            Computer computer = _computerService.FindById(id);
            if (computer == null)
            {
                return NotFound();
            }
            return View(computer);
        }
        [HttpPost]
        public IActionResult Delete(Computer model)
        {
           
             _computerService.Delete(model.Id);
             return RedirectToAction("Index");
          
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_computerService.FindById(id));
        }
        [HttpPost]
        public IActionResult Details(Computer model) 
        {
            return RedirectToAction("Index");
        }
    }
}
