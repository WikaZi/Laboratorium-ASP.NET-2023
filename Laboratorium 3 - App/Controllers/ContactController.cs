using Microsoft.AspNetCore.Mvc;
using Laboratorium_3___App.Models;

namespace Laboratorium_3___App.Controllers
{
    public class ContactController : Controller
    {
        static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        static int id = 1;
        public IActionResult Index()
        {
            return View(_contacts);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Contact model) { 
            if (ModelState.IsValid)
            {
                model.Id = id++;
                _contacts[model.Id] = model; //zapisanie modelu do bazy lub kolekcji
                return RedirectToAction("Index");
            }
            return View();
            
        }
        [HttpGet]
        public IActionResult Update(int id) 
        {

            return View(_contacts[id]);
        }
        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contacts[model.Id] = model; //zapisanie modelu do bazy lub kolekcji
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contacts[id]);

        }
        [HttpPost]
        public IActionResult Delete(Contact model)
        { 
            _contacts.Remove(model.Id);
            return RedirectToAction("Index");

        }
        public IActionResult Details(int id)
        {
           
        }

        [HttpPost]
        public IActionResult Details(Contact model) 
        {
            return RedirectToAction("Index");
        }
    }
}
