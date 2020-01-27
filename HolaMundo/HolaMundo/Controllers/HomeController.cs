using HolaMundo.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HolaMundo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var peliculasServices = new PeliculasServices();
            var model = peliculasServices.ObtenerPelicula();
            return Json(model,JsonRequestBehavior.AllowGet);
            //return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var peliculasServices = new PeliculasServices();
            var model = peliculasServices.ObtenerPeliculas();


            return View(model);
        }

        public FileResult Contact()
        {
            //ViewBag.Message = "Your contact page.";C:\Users\Admin\Source\Repos\mvc5\HolaMundo\HolaMundo\mvc.pdf
            var ruta = Server.MapPath("mvc.pdf");
            return File(ruta, "application/pdf", "Ejemplo.pdf");

            //return View();
        }
    }
}