using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Blindaje
{
    public class BlindajeUnidad : IBlindaje
    {
        public string NombreBlindaje { get; set; }
        public int Blindaje{ get; set; }

        public BlindajeUnidad(string nombreBlindaje, int Blindaje)
        {
            NombreBlindaje = nombreBlindaje;
            this.Blindaje = Blindaje;
        }

        public string MostrarBlindaje()
        {
            return $"Nombre blindaje: {this.NombreBlindaje}, Bindaje: {this.Blindaje}";
        }
    }
}
