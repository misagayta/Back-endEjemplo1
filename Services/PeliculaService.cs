﻿using Back_endEjemplo1.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Back_endEjemplo1.Services
{
    public class PeliculaService
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            var pelicula1 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 123,
                Pais = "USA",
                Publicacion = new DateTime(2015, 11, 12)
            };
            var pelicula2 = new Pelicula()
            {
                Titulo = "Superman",
                Duracion = 123,
                Pais = "USA",
                Publicacion = new DateTime(2015, 11, 12)
            };

        return new List<Pelicula>{ pelicula1,pelicula2 };

        }
    }
}