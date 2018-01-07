using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ASP_Core_EF.Services;
using ASP_Core_EF.Models;

namespace ASP_Core_EF.Controllers
{
    public class EnrollmentController : Controller
    {
        private readonly IEnrollment _Enrollment;

        public EnrollmentController(IEnrollment _IEnrollment)
        {
            _Enrollment = _IEnrollment;
        }
        public IActionResult Index()
        {
            return View(_Enrollment.GetEnrollments);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Enrollment model)
        {
            if (ModelState.IsValid)
            {
                _Enrollment.Add(model);
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}