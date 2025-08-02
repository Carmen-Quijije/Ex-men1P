using Exámen1P.Base;
using Exámen1P.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exámen1P
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BaseDatos.CargarAviones();
            BaseDatos.CargarAeropuertos();

            while (true)
            {
                Menu();
            }
        }

        private static void Menu()
        {

            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("         SISTEMA DE VUELOS");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1. Crear Aeropuerto");
            Console.WriteLine("2. Consultar todos los aeropuertos");
            Console.WriteLine("3. Consultar aeropuerto");
            Console.WriteLine("4. Modificar aeropuerto");
            Console.WriteLine("5. Eliminar aeropuerto");
            Console.WriteLine("6. Crear Avión");
            Console.WriteLine("7. Consultar todos los aviones");
            Console.WriteLine("8. Consultar avión");
            Console.WriteLine("9. Modificar avión");
            Console.WriteLine("10. Eliminar avión");
            Console.WriteLine("11. SALIR");
            Console.Write("Seleccione una opción");

            string opcion = Console.ReadLine();
            switch (opcion)
            {
                case "1":
                    CrearAeropuerto();
                    BaseDatos.GuardarAeropuertos();
                    break;
                case "2":
                    MostrartarAeropuertos();
                    break;
                case "3":
                    ConsultarAeropuerto();
                    BaseDatos.GuardarAeropuertos();
                    break;
                case "4":
                    ModificarAeropuerto();
                    BaseDatos.GuardarAeropuertos();
                    break;
                case "5":
                    EliminarAeropuerto();
                    BaseDatos.GuardarAeropuertos();
                    break;
                case "6":
                    CrearAvion();
                    BaseDatos.GuardarAviones();
                    break;
                case "7":
                    MostrarAviones();
                    break;
                case "8":
                    ConsultarAvion();
                    BaseDatos.GuardarAviones();
                    break;
                case "9":
                    ModificarAvion();
                    BaseDatos.GuardarAviones();
                    break;
                case "10":
                    ElimivarAvion();
                    BaseDatos.GuardarAviones();
                    break;
                case "11":
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opción no válida. Intente de nuevo.");
                    Console.ReadKey();
                    Menu();
                    break;
                
            }
        }

        private static void ElimivarAvion()
        {
            throw new NotImplementedException();
        }




        private static void ModificarAvion()
        {
            throw new NotImplementedException();

        }




        private static void ConsultarAvion()
        {
            throw new NotImplementedException();
        }




        private static void MostrarAviones()
        {
            throw new NotImplementedException();
        }




        private static void CrearAvion()
        {
            throw new NotImplementedException();
        }




        private static void EliminarAeropuerto()
        {
            Console.Write("Ingrese el ID del aeropuerto a eliminar: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("❌ ID inválido.\n");
                return;
            }

            var aeropuerto = BaseDatos.GetAeropuertoPorId(id);
            if (aeropuerto == null)
            {
                Console.WriteLine("❌ Aeropuerto no encontrado.\n");
                return;
            }

            BaseDatos.BaseDatosAeropuertos.Remove(aeropuerto);
            Console.WriteLine("Aeropuerto eliminado correctamente.\n");
        }




        private static void ModificarAeropuerto()
        {
            Console.Write("✏ Ingrese el ID del aeropuerto a modificar: ");
            if (!int.TryParse(Console.ReadLine(), out int id))
            {
                Console.WriteLine("❌ ID inválido.\n");
                return;
            }

            var aeropuerto = BaseDatos.GetAeropuertoPorId(id);
            if (aeropuerto == null)
            {
                Console.WriteLine("❌ Aeropuerto no encontrado.\n");
                return;
            }

            Console.WriteLine("Deje el espacio para modificar un campo.");

            Console.Write($"Nuevo nombre (actual: {aeropuerto.Nombre}): ");
            string nuevoNombre = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nuevoNombre))
                aeropuerto.Nombre = nuevoNombre;

            Console.Write($"Nueva ciudad (actual: {aeropuerto.Ciudad}): ");
            string nuevaCiudad = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nuevaCiudad))
                aeropuerto.Ciudad = nuevaCiudad;

            Console.Write($"Nuevo país (actual: {aeropuerto.Pais}): ");
            string nuevoPais = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nuevoPais))
                aeropuerto.Pais = nuevoPais;

            Console.Write($"Nueva capacidad máxima (actual: {aeropuerto.CapacidadMaxima}): ");
            string nuevaCapacidadStr = Console.ReadLine();
            if (int.TryParse(nuevaCapacidadStr, out int nuevaCapacidad))
                aeropuerto.CapacidadMaxima = nuevaCapacidad;

            Console.Write($"Nuevo número de pistas (actual: {aeropuerto.NumeroPistas}): ");
            string nuevasPistasStr = Console.ReadLine();
            if (int.TryParse(nuevasPistasStr, out int nuevasPistas))
                aeropuerto.NumeroPistas = nuevasPistas;

            Console.WriteLine("Aeropuerto modificado con éxito!!.\n");
        }




        private static void ConsultarAeropuerto()
        {
            Console.Clear();
            {
                Console.Write("Ingrese ID del aeropuerto a consultar: ");
                if (!int.TryParse(Console.ReadLine(), out int id))
                {
                    Console.WriteLine("ID inválido.\n");
                    return;
                }

                var aeropuerto = BaseDatos.GetAeropuertoPorId(id);
                if (aeropuerto != null)
                {
                    aeropuerto.ImprimirAeropuerto();
                }
                else
                {
                    Console.WriteLine("Aeropuerto no encontrado.\n");
                }
            }
        }




        private static void MostrartarAeropuertos()
        {
            Console.Clear();
            Console.WriteLine("LISTA DE AEROPUERTOS");
            Console.WriteLine("------------------------");
            BaseDatos.ImprimirTodosAeropuertos();
            Console.ReadLine();
        }




        private static void CrearAeropuerto()
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("         CREAR AEROPUERTO ");
            Console.WriteLine("------------------------------------");
            Console.Write("Nombre del Aeropuerto: ");
            string aeropuertoN = Console.ReadLine();
            Console.Write("Ciudad: ");
            string ciudad = Console.ReadLine();
            Console.Write("País: ");
            string pais = Console.ReadLine();
            Console.Write("Capacidad Máxima: ");
            int capacidad = int.Parse(Console.ReadLine());

            Aeropuerto nuevo = new Aeropuerto(aeropuertoN, ciudad, pais, capacidad);
            BaseDatos.BaseDatosAeropuertos.Add(nuevo);

            Console.WriteLine("Aeropuerto creado exitosamente.\n");
        }
    }
    
    
}

