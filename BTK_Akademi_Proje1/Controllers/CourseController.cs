using BTK_Akademi_Proje1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BTK_Akademi_Proje1.Controllers
{
    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var model = Repository.Applications;
            return View(model);
        }

        public IActionResult Apply()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Apply([FromForm] Candidate candidate)
        {
            if (Repository.Applications.Any(c=>c.Email.Equals(candidate.Email)))
            {
                ModelState.AddModelError("", "There is already an application for you.");
            }
            if (ModelState.IsValid)
            {
                Repository.Add(candidate);
                return View("FeedBack", candidate);
            }
            return View();
        }
    }
}
