using EjercicioFactoriaEjercitoC.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC.Ejercito
{
    public class EjercitoNuevo : IEjercito, Ipresupuesto, IMilitarizable, ICosteable
    {
        public int NumElementos { get; set; }
        public double CapacidadMilitar { get; set; } = 0;
        public float Presupuesto { get; set; } = 0;
        public List<IMilitarizable> EjercitoListaUnidades { get; set; } = new List<IMilitarizable>();
        public string Titulo { get; set; }
        public int Velocidad { get; set; } = 0;
        public int Blindaje { get; set; } = 0;
        public int PotenciaFuego { get; set; } = 0;
        public float Precio { get; set; } = 0;    

        public EjercitoNuevo(string NombreEjercito, float Presupuesto)
        {
            this.Titulo= NombreEjercito;
            this.Presupuesto = Presupuesto; 
        }

        public void AddUnidad(IMilitarizable Unidad)
        {
            EjercitoListaUnidades.Add(Unidad);
            this.NumElementos++;
            this.PotenciaFuego += Unidad.PotenciaFuego;
            this.Blindaje += Unidad.Blindaje;
            this.Velocidad += Unidad.Velocidad;
            this.Precio += (Unidad as ICosteable).Precio;
            this.CapacidadMilitar = CalculoCapacidadMilitar();
        }

        public double CalculoCapacidadMilitar()
        {
            return (((double)this.PotenciaFuego * (double)this.Velocidad) / 2) / (100 - (double)this.Blindaje);
        }

        public string Mostrar()
        {
            return $"Nombre Ejercito: {this.Titulo}, Número de elementos: {this.NumElementos}, Potencia total: {this.PotenciaFuego}, " +
                $"Blindaje total {this.Blindaje}, Velocidad total: {this.Velocidad}, Gasto total: {this.Precio}, Capacidad militar: {Math.Round(this.CapacidadMilitar, 2)}, " +
                $"Presupuesto: {this.Presupuesto}, Presupuesto disponible: {this.Presupuesto - this.Precio}";
        }
        public string MostrarUnidadesEjercito()
        {
            string Cadena = "";
            foreach (IMilitarizable Unidad in EjercitoListaUnidades)
            {
                Cadena += Unidad.Mostrar();
                Console.WriteLine($"{Unidad.Mostrar()}");
            }
            return Cadena;
        }
    }
}
