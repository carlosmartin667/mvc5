using HolaMundo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HolaMundo.Dal
{
    public class PeliculaRepository
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            return new List<Pelicula>()
            {
                new Pelicula()
                {
                    Pais="eeuu",
                    Titulo="jsda",
                    Duracion=123

                },
                 new Pelicula()
                {
                    Pais="canada",
                    Titulo="asdas",
                    Duracion=2342

                },
                  new Pelicula()
                {
                    Pais="china",
                    Titulo="sa",
                    Duracion=34

                },
            };
        }
    }
}