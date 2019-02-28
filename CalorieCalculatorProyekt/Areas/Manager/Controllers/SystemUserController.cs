using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CalorieCalculatorProyekt.Areas.Manager.Models;

namespace CalorieCalculatorProyekt.Areas.Manager.Controllers
{
    [RouteArea("manager")]
    public class SystemUserController : Controller
    {
       
        [Route("login")]
        public ActionResult Index()
        {

            return View( new SystemUser());
        }


        [HttpPost]
        public ActionResult Login(SystemUser model)
        {

            return View();
        }
    }
}