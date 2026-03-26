using System;
using System.Collections.Generic;
using System.Text;

namespace Proyecto.Decorador
{
    public abstract class AgregadoDecorator : TecnmComponent
    {
        protected TecnmComponent _tecnm;

        public AgregadoDecorator(TecnmComponent tecnm)
        {
            _tecnm = tecnm;
        }
    }
}