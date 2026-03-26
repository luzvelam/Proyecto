using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Decorador
{
    public abstract class TecnmComponent
    {
        public abstract string Clave { get; }
        public abstract string Descripcion { get; }
    }
}