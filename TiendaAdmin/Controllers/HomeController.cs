using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Business;
using Interface;
using Interfaces;

namespace TiendaAdmin.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
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

        public ActionResult Testing()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Category()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Brand()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Product()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Users()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Conexion()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        //public JsonResult ListUser()
        //{
        //    List<User> olist = new List<User>();
        //    olist = new Buser().ListUser();

        //    return Json(olist, JsonRequestBehavior.AllowGet );
        //}

        [HttpGet]
        public JsonResult ListUser()
        {
            List<User> olist = new Buser().ListUser();
            return Json(new { data = olist }, JsonRequestBehavior.AllowGet);
        }


        [HttpPost]
        public JsonResult CreateUser(User objeto)
        {
            object result;
            string message = string.Empty;

            // Llamada al método para crear el usuario
            result = new Buser().Create(objeto, out message);
            string alert = Balert.GenerateAlert("Usuario creado exitosamente.", "success");

            return Json(new { result = result, message = message, alert }, JsonRequestBehavior.AllowGet);
        }



        //[HttpPost]
        //public JsonResult EditUser(User objeto)
        //{
        //    object result;
        //    string message = string.Empty;

        //    result = new Buser().Edit(objeto, out message);

        //    return Json(new { result = result, message = message }, JsonRequestBehavior.AllowGet);


        //}

    }
}