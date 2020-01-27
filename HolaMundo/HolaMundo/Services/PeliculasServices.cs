using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundo.Services
{
    public class PeliculasServices
    {
        public Pelicula ObtenerPelicula()
        {
            return new Pelicula()
            {
                Titulo = "piter pan",
                Duracion = 140,
            Pais="EEUU",
            Publicacion =new DateTime(2019,10,9)
            };
        }
        public List<Pelicula> ObtenerPeliculas()
        {
            var p1 = new Pelicula() {
                Titulo = "piter pan",
                Duracion = 140,
                Pais = "EEUU",
                Publicacion = new DateTime(2019, 10, 9)
            };
            var p2 = new Pelicula()
            {
                Titulo = "dragon ball",
                Duracion = 140,
                Pais = "japon",
                Publicacion = new DateTime(2019, 10, 9)
            };
            return new List<Pelicula> { p1, p2 };
        }
    }
}