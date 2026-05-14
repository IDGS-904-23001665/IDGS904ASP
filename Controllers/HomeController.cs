using IDGS904ASP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace IDGS904ASP.Controllers
{
    public class HomeController : Controller
    {
        /*public ActionResult Index()
        {
            return View();
        }*/

        /*public ViewResult Index()
        {
            return View();
        }

        public ContentResult Index()
        {
            return ContentResult("Hola ASP.NET");
        }



        public JsonResult Index()
        {
            var Alumno1 = new Persona()
            {
                Nombre = "Juan",
                Edad = 25,
                Empleado = true
            };
            var Alumno2 = new Persona()
            {
                Nombre = "Daniel",
                Edad = 31,
                Empleado = false
            };
            //return View();
            return Json(new List<Persona>() { Alumno1, Alumno2 }, JsonRequestBehavior.AllowGet);


        }*/

        /*public RedirectResult Index()
        {
            return Redirect("https://google.com.mx/");
        }*/

        public RedirectToRouteResult Index()
        {
            return RedirectToAction("Index", "Pruebas");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}