using System;
using System.Collections.Generic;
using System.Text;

using Proyecto.Bridge;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Decorador
{
    public class Calculo : AgregadoDecorator
    {
        private List<IMaterial> materiales = new List<IMaterial>();

        public Calculo(TecnmComponent tecnm) : base(tecnm)
        {
            materiales.Add(new Libro("Calculo Stewart"));
            materiales.Add(new Libro("Calculo Larson"));
        }

        public override string Clave => _tecnm.Clave + "C1S";

        public override string Descripcion
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine(_tecnm.Descripcion + ", Materia: Calculo");

                foreach (var m in materiales)
                    sb.AppendLine("   - " + m.ObtenerDescripcion());

                return sb.ToString();
            }
        }
    }
}