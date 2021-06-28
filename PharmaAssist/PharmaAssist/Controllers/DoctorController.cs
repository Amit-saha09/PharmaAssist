using PharmaAssist.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PharmaAssist.Controllers
{
    public class DoctorController : Controller
    {
        DoctorRepository contex = new DoctorRepository();
        // GET: Doctor
        public ActionResult Index()
        {
            return View(contex.GetAll());
        }
        public ActionResult Details(int Id)
        {
            var p = new BlogPostRepository();
            ViewData["userblog"] = p.GetUserPosts(Id);
            return View(contex.Get(Id));
        }

        public ActionResult Profile(int Id)
        {

            var p = contex.Getuserinfo(Id);
            return View(p);
        }

    }
}