﻿using Microsoft.AspNetCore.Mvc;

namespace PRIMEIRO_PROJETO.Controllers
{
    public class ProfessorController : Controller
    {
        public IActionResult Index()
        {
            return View("Professor");
        }
    }
}


//// PAREI EM DATA PROFESOR