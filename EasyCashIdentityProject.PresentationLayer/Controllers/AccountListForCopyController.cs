﻿using Microsoft.AspNetCore.Mvc;

namespace EasyCashIdentityProject.PresentationLayer.Controllers
{
    public class AccountListForCopyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
