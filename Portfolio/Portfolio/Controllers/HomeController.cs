using Portfolio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Web;
using System.Web.Mvc;
using System.Xml.Linq;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.name = "Zobayer Alam";
            ViewBag.email = "21-44487-1@student.aiub.edu";
            ViewBag.contact = "01774861518";
            ViewBag.deg = "Bsc CSE";
            ViewBag.exp = "HTML/CSS/SQL";
            return View();
        }

        public ActionResult Education()
        {
            ViewBag.Message = "My Education Description page.";

            return View();
        }

        public ActionResult Projects()
        {
            Projects p1 = new Projects()
            {
                Title = "title 1",
                Des = "des 1",
                Course = "course 1"
            };
            Projects p2 = new Projects()
            {
                Title = "title 2",
                Des = "des 2",
                Course = "course 2"
            };
            Projects p3 = new Projects()
            {
                Title = "Rahman",
                Des = "des 3",
                Course = "course 3"
            };


            ViewBag.Projects = new Projects[] { p1, p2, p3 };
            return View();
        }

        public ActionResult Certificates()
        {
            ViewBag.Message = "My Certificate page";

            return View();
        }
        
        public ActionResult Reference()
        {
            ViewBag.Message = "My Reference page";

            @ViewBag.Message = "";
            @ViewBag.ref1sl = "1";
            @ViewBag.ref1name = "Ref 1 Name";
            @ViewBag.ref1contact = "Ref 1 contact";

            @ViewBag.ref1sl = "2";
            @ViewBag.ref1name = "ref 2 name";
            @ViewBag.ref1contact = "ref 2 contact";
            return View();
        }

        public ActionResult Form()
        {
            return View();
        }
    }
}