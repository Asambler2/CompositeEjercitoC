using EjercicioFactoriaEjercitoC.Blindaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaBlindaje
{
    public interface IFactoriaBlindaje
    {
        public IBlindaje DameBlindajeUnidad();
    }
}
