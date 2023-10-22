using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Laboratorium_3___App.Controllers
{
    public class ComputerController : Controller
    {
        static Dictionary<int, Computer> _computers =  new Dictionary<int, Computer>();
        static int id = 1;
        public IActionResult Index()
        {
            return View(_computers);
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
                model.Id = id++;
                _computers[model.Id] = model; //zapisanie modelu do bazy lub kolekcji
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Update(int id)
        {
            return View(_computers[id]);
        }
        [HttpPost]
        public IActionResult Update(Computer model)
        {
            if(ModelState.IsValid)
            {
                _computers[model.Id] = model;
                return RedirectToAction("Index");
            }
            return View();
        }
        

        [HttpGet]
        public IActionResult Delete(int id) 
        {
            return View(_computers[id]);
        }
        [HttpPost]
        public IActionResult Delete(Computer model)
        {
            _computers.Remove(model.Id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_computers[id]);
        }
        [HttpPost]
        public IActionResult Details(Computer model) 
        {
            return RedirectToAction("Details");
        }
    }
}
