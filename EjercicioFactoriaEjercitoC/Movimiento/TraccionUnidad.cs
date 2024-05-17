using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Movimiento
{
    public class TraccionUnidad : IVelocidad
    {
        public string NombreTraccion { get; set; }
        public int Velocidad { get; set; }

        public TraccionUnidad(string nombreTraccion, int velocidad)
        {
            NombreTraccion = nombreTraccion;
            this.Velocidad = velocidad;
        }

        public string MostrarTraccion()
        {
            return $"Nombre tracción: {this.NombreTraccion}, Velocidad: {this.Velocidad}";
        }
    }
}
