using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using Exámen1P.Clases;


namespace Exámen1P.Base
{
    public static class BaseDatos
    {
        public static List<Avion> BaseDatosAvion = new List<Avion>();
        public static List<Aeropuerto> BaseDatosAeropuertos = new List<Aeropuerto>();

        private static string ArchivoAviones = "Aviones.dat";
        private static string nombreArchivoAeropuertos = "Aeropuertos.dat";

        // ---------------------- AVIONES ----------------------
        public static void GuardarAviones()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(ArchivoAviones, FileMode.Create);
            bf.Serialize(fs, BaseDatosAvion);
        }

        public static void CargarAviones()
        {
            if (File.Exists(ArchivoAviones)) 
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(ArchivoAviones, FileMode.Open);
                BaseDatosAvion = (List<Avion>)bf.Deserialize(fs);
            }
        }

        public static Avion GetAvionPorId(int id)
        {
            foreach (var avion in BaseDatosAvion)
            {
                if (avion.Id == id)
                    return avion;
            }
            return null;
        }

        public static void ImprimirTodosAviones()
        {
            foreach (var avion in BaseDatosAvion)
            {
                Console.WriteLine($"ID: {avion.Id} | Modelo: {avion.Modelo} | Estado: {avion.Estado}");
            }
        }

        // ---------------------- AEROPUERTOS ----------------------
        public static void GuardarAeropuertos()
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream(nombreArchivoAeropuertos, FileMode.Create);
            bf.Serialize(fs, BaseDatosAeropuertos);
        }

        public static void CargarAeropuertos()
        {
            if (File.Exists(nombreArchivoAeropuertos))
            {
                BinaryFormatter bf = new BinaryFormatter();
                FileStream fs = new FileStream(nombreArchivoAeropuertos, FileMode.Open);
                BaseDatosAeropuertos = (List<Aeropuerto>)bf.Deserialize(fs);
            }
        }

        public static Aeropuerto GetAeropuertoPorId(int id)
        {
            foreach (var aeropuerto in BaseDatosAeropuertos)
            {
                if (aeropuerto.Id == id)
                    return aeropuerto;
            }
            return null;
        }

        public static void ImprimirTodosAeropuertos()
        {
            foreach (var aeropuerto in BaseDatosAeropuertos)
            {
                Console.WriteLine($"ID: {aeropuerto.Id} | Nombre: {aeropuerto.Nombre} | Ciudad: {aeropuerto.Ciudad} | Código: {aeropuerto.Codigo}");
            }
        }
    }
}
