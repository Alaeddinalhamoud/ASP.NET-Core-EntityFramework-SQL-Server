using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_Core_EF.Services;
using ASP_Core_EF.Models;

namespace ASP_Core_EF.Controllers
{
    public class GenderController : Controller
    {
        private readonly IGender _Gender;
        public GenderController(IGender _IGender)
        {
            _Gender = _IGender;
        }
        public IActionResult Index()
        {
            return View(_Gender.GetGenders);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Gender model)
        {
            if (ModelState.IsValid)
            {
                _Gender.Add(model);
                return RedirectToAction("Index");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Delete(int? Id)
        {
            if (Id == null)
            {
                //Error 
                return NotFound();
            }

            else
            {
                Gender model = _Gender.GetGender(Id);
                return View(model);
            }
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirm(int? Id)
        {
            _Gender.Remove(Id);
            return RedirectToAction("Index");

        }

    }
}