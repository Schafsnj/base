﻿using APPS_Web_APP.Models;
using APPS_Web_APP.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APPS_Web_APP.Controllers
{
    public class LoginController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ProcessLogin(User usermodel)
        {
            SecurityService securityService = new SecurityService();
            if(securityService.IsValid(usermodel))
            {
                if(securityService.checkManager(usermodel))
                {
                    return RedirectToAction("checkLogin", "Manager", usermodel);
                }
                else
                {
                    return View("Employee", usermodel);
                }

            }
            else
            {
                return View("LoginFailure", usermodel);
            }
        }
    }
}
