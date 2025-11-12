using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3Patrones
{
    public abstract class SistemaDecorator : SistemaComponent
    {
        protected SistemaComponent _sistema;

        public SistemaDecorator(SistemaComponent sistema)
        {
            _sistema = sistema;
        }
    }
}
