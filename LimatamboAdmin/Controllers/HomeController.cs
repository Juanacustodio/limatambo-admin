using LimatamboAdmin.DAL;
using LimatamboAdmin.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LimatamboAdmin.Controllers
{
    public class HomeController : Controller
    {
        private LimatamboContext db = new LimatamboContext();
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index([Bind(Include = "correo,contrasena")] Login login)
        {
            if (login.correo.Length == 0 || login.contrasena.Length == 0)
            {
                ViewBag.Message = "Correo y contraseña no pueden estar vacíos.";
                return View();
            }

            Admin admin = db.Admin.FirstOrDefault<Admin>(a => a.correo == login.correo && a.contrasena == login.contrasena);

            if (admin == null)
            {
                ViewBag.Message = "No se encontró el usuario ADMIN.";
                return View();
            }

            Session.Add("admin", admin);
            return RedirectToAction("Dashboard");
        }

        public ActionResult Salir()
        {
            Session.Remove("admin");
            return RedirectToAction("Index");
        }

        public ActionResult Dashboard()
        {
            return View();
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