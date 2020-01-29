using HolaMundo.Dal;
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
        private PeliculaRepository _peliculaRepository;
        public ActionResult Index()
        {
            var peliculasServices = new PeliculasServices();
            var model = peliculasServices.ObtenerPelicula();
            return Json(model,JsonRequestBehavior.AllowGet);
            //return View();
        }

        public ActionResult DisplayTemplates()
        {
            var personas = new Personas()
            {
                Nombre = "martin",
                Edad = 20,
                Empleado = true,
                Nacimiento=new DateTime(2000, 2,10)
            };
            ViewBag.Propiedad = personas;

            return View();
        } 

        public ActionResult About(string nombre)
        {
            ViewBag.Message = "Your application description page." +nombre;

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


        [HttpGet]
        public ActionResult Formularrio()
        {
            ViewBag.Message = "Your application description page." ;
            return View();
        }
        [HttpPost]
        public ActionResult Formularrio(int edad)
        {
            ViewBag.Message = "Your application description page." + edad;
            return View();
        }


        public HomeController()
        {
            _peliculaRepository = new PeliculaRepository();
        }

        public ActionResult Pelicula()
        {
            ViewBag.Message = "Your application description page.";
            var model = _peliculaRepository.ObtenerPeliculas();
            return View(model);
        }

        public ActionResult Detalle(string t)
        {
            ViewBag.Message = "titulo de pelicula." + t;
           
            return View();
        }
    }
}

public class Personas
{
    public int Edad { get; set; }
    public string Nombre { get; set; }
    public bool Empleado { get; set; }
    public DateTime Nacimiento { get; set; }
}