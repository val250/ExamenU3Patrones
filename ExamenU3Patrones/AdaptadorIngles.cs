using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3Patrones
{
    public class AdaptadorIngles : ITraductor
    {
        private SistemaComponent _sistema;

        public AdaptadorIngles(SistemaComponent sistema)
        {
            _sistema = sistema;
        }

        public string ObtenerDescripcionTraducida()
        {
            string texto = _sistema.Descripcion;

            texto = texto.Replace("Sistema de monitoreo para Cocina", "Monitoring system for Kitchen")
                         .Replace("Sistema de monitoreo para Sala", "Monitoring system for Living room")
                         .Replace("Cámara de vigilancia", "Security camera")
                         .Replace("Detector de humo", "Smoke detector")
                         .Replace("Detector de gas", "Gas detector")
                         .Replace("Alerta de movimiento", "Motion alert")
                         .Replace("Alerta de cámara desconectada", "Disconnected camera alert")
                         .Replace("Alerta de mantenimiento a detectores", "Maintenance alert for detectors")
                         .Replace("Cantidad", "Quantity")
                         .Replace("Descripción", "Description");

            return texto;
        }
    }
}
