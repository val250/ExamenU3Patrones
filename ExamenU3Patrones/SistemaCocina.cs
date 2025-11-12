using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3Patrones
{
    public class SistemaCocina : SistemaComponent
    {
        public override string Descripcion => "Sistema de monitoreo para Cocina" +
            "\n  Cantidad   Descripción"  + 
            "\n - (2)       Cámara de vigilancia" +
            "\n - (1)       Detector de humo" + 
            "\n - (2)       Detector de gas";
    }
}
