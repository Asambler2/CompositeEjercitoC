using EjercicioFactoriaEjercitoC.Blindaje;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.FabricaBlindaje
{
    internal class FactoriaBlindajeUnidad : IFactoriaBlindaje
    {
        public IBlindaje DameBlindajeUnidad()
        {
            {
                string NombreBlindaje = "";
                int Blindaje = 0;
                Console.WriteLine("Mete el nombre del blindaje.");
                NombreBlindaje = Console.ReadLine();
                Console.WriteLine("Mete el valor del blindaje.");
                Blindaje = int.Parse(Console.ReadLine());
                return new BlindajeUnidad(NombreBlindaje, Blindaje);
            }
        }
    }
}
