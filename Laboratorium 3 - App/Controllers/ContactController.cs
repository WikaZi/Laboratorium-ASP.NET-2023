﻿using Microsoft.AspNetCore.Mvc;
using Laboratorium_3___App.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Authorization;

namespace Laboratorium_3___App.Controllers
{
    [Authorize(Roles = "admin")]
    public class ContactController : Controller
    {
        private readonly IContactService _contactService;

        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }
        [AllowAnonymous]
        public IActionResult Index()
        {
            return View(_contactService.FindAll());
        }
        [HttpGet]
        public ActionResult Create()
        {
            Contact model = new Contact();
            model.OrganizationList = _contactService
                .FindAllOrganizations()
                .Select(o => new SelectListItem() { Value = o.Id.ToString(), Text = o.Name})
                .ToList();
            return View(model);
        }
        [HttpPost]
        public IActionResult Create(Contact model) {
            if (ModelState.IsValid)
            {
                _contactService.Add(model);
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

            return View(_contactService.FindById(id));
        }
        [HttpPost]
        public IActionResult Update(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Update(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            return View(_contactService.FindById(id));

        }
        [HttpPost]
        public IActionResult Delete(Contact model)
        {
            if (ModelState.IsValid)
            {
                _contactService.Delete(model.Id);
                return RedirectToAction("Index");
            }
            return View(model);

        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            return View(_contactService.FindById(id));
        }

        [HttpPost]
        public IActionResult Details(Contact model) 
        {
            return RedirectToAction("Index");
        }
    }
}
