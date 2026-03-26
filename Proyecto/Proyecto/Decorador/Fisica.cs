using System;
using System.Collections.Generic;
using System.Text;

using Proyecto.Bridge;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Decorador
{
    public class Fisica : AgregadoDecorator
    {
        private List<IMaterial> materiales = new List<IMaterial>();

        public Fisica(TecnmComponent tecnm) : base(tecnm)
        {
            materiales.Add(new Libro("Fisica Vol 1"));
            materiales.Add(new Libro("Fisica Vol 2"));
        }

        public override string Clave => _tecnm.Clave + "F1S";

        public override string Descripcion
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(_tecnm.Descripcion + ", Materia: Fisica");

                foreach (var m in materiales)
                    sb.AppendLine("   - " + m.ObtenerDescripcion());

                return sb.ToString();
            }
        }
    }
}