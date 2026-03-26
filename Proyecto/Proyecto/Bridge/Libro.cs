using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Bridge
{
    public class Libro : IMaterial
    {
        private string nombre;

        public Libro(string nombre)
        {
            this.nombre = nombre;
        }

        public string ObtenerDescripcion()
        {
            return "Libro: " + nombre;
        }
    }
}