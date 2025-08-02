using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exámen1P.Base;

namespace Exámen1P.Clases
{
    [Serializable]
    public class Aeropuerto
    {
        private static int contadorId = 1;
        private int id;
        private string aeropuerto;
        private string ciudad;
        private string pais;
        private int capacidadMaxima;
        private string codigo;
        private int numeroPistas;
        private int numeroVuelosDiarios;

        public Aeropuerto(string aeropuertoN, string ciudad, string pais, int capacidadMaxima)
        {
            this.id = contadorId++;
            this.aeropuerto = aeropuertoN;
            this.ciudad = ciudad;
            this.pais = pais;
            this.capacidadMaxima = capacidadMaxima;
            this.codigo = GenerarCodigo();
            this.numeroPistas = 3;
            this.numeroVuelosDiarios = CalcularVuelosDiarios();
        }

        private string GenerarCodigo() => (aeropuerto.Substring(0, 3) + ciudad.Substring(0, 2)).ToUpper();
        private int CalcularVuelosDiarios() => capacidadMaxima * 2;

        public int Id => id;
        public string Nombre { get => aeropuerto; set { aeropuerto = value; codigo = GenerarCodigo(); } }
        public string Ciudad { get => ciudad; set { ciudad = value; codigo = GenerarCodigo(); } }
        public string Pais { get => pais; set => pais = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public string Codigo => codigo;
        public int NumeroPistas { get => numeroPistas; set => numeroPistas = value; }
        public int NumeroVuelosDiarios => numeroVuelosDiarios;



        public void ImprimirAeropuerto()
        {
            Console.WriteLine("=== AEROPUERTO ===");
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Nombre: {aeropuerto}");
            Console.WriteLine($"Ciudad: {ciudad}");
            Console.WriteLine($"País: {pais}");
            Console.WriteLine($"Capacidad Máxima: {capacidadMaxima}");
            Console.WriteLine($"Código: {codigo}");
            Console.WriteLine($"Número de Pistas: {numeroPistas}");
            Console.WriteLine($"Vuelos Diarios: {numeroVuelosDiarios}");
            Console.WriteLine("==================\n");
        }
    }
}        
