using EjercicioFactoriaEjercitoC.Blindaje;
using EjercicioFactoriaEjercitoC.Movimiento;
using EjercicioFactoriaEjercitoC.Potencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Unidades
{
    public interface IMilitarizable
    {
        public string Titulo { get; set; }
        public IVelocidad Velocidad {  get; set; }
        public IBlindaje Blindaje { get; set; }
        public IPotenciaFuego PotenciaFuego { get; set; }
        public string Mostrar();
    }
}
