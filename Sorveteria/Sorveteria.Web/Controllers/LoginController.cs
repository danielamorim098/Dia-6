﻿using Sorveteria.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sorveteria.Web.Controllers
{
    public class LoginController : Controller
    {

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }



        [HttpPost]
        public ActionResult Index(User user)
        {
            if (user.Senha== "123")
            {
                return RedirectToAction("Index", "Home");
            }

            ModelState.AddModelError("senha", "senha invalida");

            return View();
        }


    }


}