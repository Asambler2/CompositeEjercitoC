using EjercicioFactoriaEjercitoC.Blindaje;
using EjercicioFactoriaEjercitoC.Movimiento;
using EjercicioFactoriaEjercitoC.Potencia;
using EjercicioFactoriaEjercitoC.Unidades;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaUnidad
{
    public interface IFactoriaUnidad
    {
        public IMilitarizable DameUnidad(string titulo, IVelocidad Velocidad, IBlindaje Blindaje, IPotenciaFuego PotenciaFuego, float precio);
    }
}
