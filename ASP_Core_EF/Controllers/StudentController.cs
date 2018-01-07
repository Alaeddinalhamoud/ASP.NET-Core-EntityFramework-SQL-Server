using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_Core_EF.Services;
using ASP_Core_EF.Models;

namespace ASP_Core_EF.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _Student;
        private readonly IGender _Gender;

        public StudentController(IStudent _IStudent,IGender _IGender)
        {
            _Student = _IStudent;
            _Gender = _IGender;
        }
        public IActionResult Index()
        {
            return View(_Student.GetStudents);
        }
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Genders = _Gender.GetGenders;
            return View();
        }
        [HttpPost]
        public IActionResult Create(Student model)
        {
            if (ModelState.IsValid)
            {
                _Student.Add(model);
              return  RedirectToAction("Index");
            }
            return View(model);
        }
    }
}