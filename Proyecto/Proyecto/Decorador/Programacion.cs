using System;
using Proyecto.Bridge;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Decorador
{
    public class Programacion : AgregadoDecorator
    {
        private List<IMaterial> materiales = new List<IMaterial>();

        public Programacion(TecnmComponent tecnm) : base(tecnm)
        {
            // Aquí definen los materiales (Bridge)
            materiales.Add(new Libro("C# Basico"));
            materiales.Add(new Libro("POO en C#"));
        }

        public override string Clave => _tecnm.Clave + "P1S";

        public override string Descripcion
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(_tecnm.Descripcion + ", Materia: Programacion");

                foreach (var m in materiales)
                    sb.AppendLine("   - " + m.ObtenerDescripcion());

                return sb.ToString();
            }
        }
    }
}