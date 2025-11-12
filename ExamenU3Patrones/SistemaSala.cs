using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3Patrones
{
    public class SistemaSala : SistemaComponent
    {
        public override string Descripcion => "Sistema de monitoreo para Sala" +
            "\n  Cantidad   Descripción" +
            "\n - (3)       Cámara de vigilancia" +
            "\n - (1)       Detector de humo" +
            "\n - (1)       Detector de gas";
    }
}
