using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenU3Patrones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool sistemavalido = false, personalizando = true;
            string opcion = "";

            SistemaComponent sistema = null;
            
            while(!sistemavalido)
            {
                Console.WriteLine("ARMA TU SISTEMA DE MONITOREO");
                Console.WriteLine("");
                Console.WriteLine("1) Sistema de monitoreo de Cocina");
                Console.WriteLine("2) Sistema de monitoreo de Sala");

                Console.Write("\nElige una opción: ");
                opcion = Console.ReadLine();

                Console.Clear();

                switch(opcion)
                {
                    case "1":
                        sistema = new SistemaCocina(); ;
                        sistemavalido = true;
                        break;
                    case "2":
                        sistema = new SistemaSala();
                        sistemavalido = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

                Console.WriteLine($"Sistema Seleccionado\n{sistema.Descripcion}");

                Console.WriteLine("\n¿Deseas agregar alertas adicionales a tu sistema?");
                Console.WriteLine("1) Si\n2) No");
                Console.Write("Elige una opción: ");
                opcion = Console.ReadLine();
                Console.Clear();

                if(opcion == "1")
                {
                    while(personalizando)
                    {
                        Console.WriteLine("Opciones de personalización:");
                        Console.WriteLine("1) Agregar alerta de movimiento");
                        Console.WriteLine("2) Agregar alerta de cámara desconectada");
                        Console.WriteLine("3) Agregar alerta de mantenimiento a detectores");
                        Console.WriteLine("4) Finalizar personalización");

                        Console.Write("\nElige una opción: ");
                        opcion = Console.ReadLine();

                        switch(opcion)
                        {
                            case "1":
                                sistema = new MovimientoDecorador(sistema);
                                Console.WriteLine("Alerta de movimiento agregada");
                                break;
                            case "2":
                                sistema = new DesconectadaDecorator(sistema);
                                Console.WriteLine("Alerta de cámara desconectada agregada");
                                break;
                            case "3":
                                sistema = new MantenimientoDecorator(sistema);
                                Console.WriteLine("Alerta de mantenimiento de detectores agregada");
                                break;
                            case "4":
                                personalizando = false;
                                break;
                            default:
                                Console.WriteLine("\nOpción no válida");
                                break;
                        }
                        Console.ReadKey();
                        Console.Clear();
                    }
                }

                Console.WriteLine("RESUMEN DE TU SISTEMA");
                Console.WriteLine(sistema.Descripcion);
                ITraductor traductor = new AdaptadorIngles(sistema);
                Console.WriteLine("\nRESUMEN EN INGLÉS");
                Console.WriteLine(traductor.ObtenerDescripcionTraducida());
                Console.ReadKey();
            }
        
        }
    }
}
