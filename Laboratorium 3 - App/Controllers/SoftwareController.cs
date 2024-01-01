using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Laboratorium_3___App.Controllers
{
    public class SoftwareController : Controller
    {
        private readonly ISoftwareService _softwareService;
        public SoftwareController(ISoftwareService softwareService)
        {
            _softwareService = softwareService;
        }
      
        public ActionResult Index()
        {
            return View(_softwareService.FindAll());
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_softwareService.FindById(id));
        }
        [HttpPost]
        public IActionResult Details(Computer model)
        {
            return RedirectToAction("Index");
        }

  

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
       
        public ActionResult Create(Software model)
        {
            if (ModelState.IsValid)
            {
                _softwareService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Update(int id)
        {
            return View(_softwareService.FindById(id));
        }

       
        [HttpPost]
        
        public ActionResult Update(Software model)
        {
            if (ModelState.IsValid)
            {
                _softwareService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Software software = _softwareService.FindById(id);
            if (software == null)
            {
                return NotFound();
            }
            return View(software);
        }

        
        [HttpPost]
       
        public ActionResult Delete(Software model)
        {
            _softwareService.Delete(model.Id);
            return RedirectToAction("Index");
        }
    }
}
