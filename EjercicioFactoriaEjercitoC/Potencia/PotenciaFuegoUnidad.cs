using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Potencia
{
    public class PotenciaFuegoUnidad : IPotenciaFuego
    {
        public string NombreArma { get; set; }
        public int Potencia { get; set; }

        public PotenciaFuegoUnidad(string nombreArma, int Potencia)
        {
            this.NombreArma = nombreArma;
            this.Potencia = Potencia;
        }

        public string MostrarArma()
        {
            return $"Nombre arma: {this.NombreArma}, potencia: {this.Potencia}";
        }
    }
}
