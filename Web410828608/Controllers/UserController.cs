using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web410828608.ViewModels;

namespace Web410828608.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: User
        public ActionResult SignUp()
        {
            
            return View(model: new SignUpData());
        }
        [HttpPost]
        public ActionResult SignUp(SignUpData data)
        {
            
            if (ModelState.IsValid)
            {
                data.Message = "註冊成功";
            }

            return View(data);
        }

    }
}