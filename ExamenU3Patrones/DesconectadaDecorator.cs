using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3Patrones
{
    public class DesconectadaDecorator : SistemaDecorator
    {
        public DesconectadaDecorator(SistemaComponent sistema) : base(sistema) { }

        public override string Descripcion => $"{_sistema.Descripcion}\n - Alerta de cámara desconectada";
    }
}
