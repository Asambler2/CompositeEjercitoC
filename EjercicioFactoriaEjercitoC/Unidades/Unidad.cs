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
    public class Unidad : IMilitarizable, ICosteable
    {
        public string Titulo { get; set; }
        public IVelocidad Velocidad { get; set; }
        public IBlindaje Blindaje { get; set; }
        public IPotenciaFuego PotenciaFuego { get; set; }
        public float Precio { get; set; }

        public Unidad (string titulo, IVelocidad Velocidad, IBlindaje Blindaje, IPotenciaFuego PotenciaFuego, float precio)
        {
            Titulo = titulo;
            this.Velocidad = Velocidad.Velocidad;
            this.Blindaje = Blindaje.Bindaje;
            this.PotenciaFuego = PotenciaFuego.PotenciaFuego;
            Precio = precio;
        }

        public string Mostrar()
        {
            return $"Unidad: {this.Titulo} con velocidad: {this.Velocidad}, blindaje: {this.Blindaje}, potencia de fuego: {this.PotenciaFuego} y precio: {this.Precio}";
        }
    }
}
