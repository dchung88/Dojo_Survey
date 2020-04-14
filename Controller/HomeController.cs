using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey.Models;

namespace Dojo_Survey.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        [HttpGet]
        public ViewResult Index()
        {
            return View("Index");
        }

        [HttpPost]
        [Route("display")]
        public IActionResult Display(Survey userSurvey)
        {
            return View("Display", userSurvey);
        }

    }
}