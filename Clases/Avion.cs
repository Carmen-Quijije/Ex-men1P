using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exámen1P.Clases
{
    [Serializable]
    public class Avion
    {
        private static int contadorId = 1;
        private int id;
        private string modelo;
        private int capacidad;
        private double velocidadMaxima;
        private double autonomia;
        private string estado;
        private int horasVuelo;
        private double combustible;

        public Avion(string modelo, int capacidad, double velocidadMaxima, double autonomia)
        {
            this.id = contadorId++;
            this.modelo = modelo;
            this.capacidad = capacidad;
            this.velocidadMaxima = velocidadMaxima;
            this.autonomia = autonomia;
            this.estado = "En tierra";
            this.horasVuelo = 0;
            this.combustible = CalcularCombustible();
        }
        private double CalcularCombustible() => autonomia * 0.8;

        public int Id => id;
        public string Modelo { get => modelo; set => modelo = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public double VelocidadMaxima { get => velocidadMaxima; set => velocidadMaxima = value; }
        public double Autonomia
        {
            get => autonomia;
            set
            {
                autonomia = value;
                combustible = CalcularCombustible();
            }
        }
        public string Estado { get => estado; set => estado = value; }
        public int HorasVuelo { get => horasVuelo; set => horasVuelo = value; }
        public double Combustible { get => combustible; set => combustible = value; }
    }
}

            
