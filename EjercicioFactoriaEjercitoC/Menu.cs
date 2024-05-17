using EjercicioFactoriaEjercitoC.Ejercito;
using EjercicioFactoriaEjercitoC.Unidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioFactoriaEjercitoC
{
    public class Menu
    {
        IMilitarizable GrupoEjercitos;

        public void GenerarMenu()
        {
            GrupoEjercitos = GenerarGrupoEjercitos();
            MenuEjercito();
        }
        public void MenuEjercito()
        {
            int Comando = 0;
            Comando = OpcionesGrupoEjercitos();
            switch(Comando)
            {
                case 1: ((EjercitoNuevo)GrupoEjercitos).AddUnidad(CrearEjercito());
                    break;
                case 2: ((EjercitoNuevo)GrupoEjercitos).MostrarUnidadesEjercito();
                    break;  
                case 3: IMilitarizable Ejercito = BuscarEjercito();
                    MenuEjercito(Ejercito);
                    break;
            }
            if (Comando != 0) MenuEjercito();
        }

        public EjercitoNuevo GenerarGrupoEjercitos()
        {
            string Nombre = "";
            float Presupuesto;
            Console.WriteLine("Introduce el nombre del grupo de ejercitos.");
            Nombre = Console.ReadLine();
            Console.WriteLine("Introduce el presupuesto.");
            Presupuesto = float.Parse(Console.ReadLine());  
            return new EjercitoNuevo(Nombre, Presupuesto);  
        }

        public int OpcionesGrupoEjercitos()
        {
            Console.WriteLine("Pulsa 0 para salir.");
            Console.WriteLine("Pulsa 1 para generar un nuevo ejercito.");
            if (((IEjercito)this.GrupoEjercitos).EjercitoListaUnidades.Count != 0)Console.WriteLine("Pulsa 2 para mostrar Ejercitos.");
            if (((IEjercito)this.GrupoEjercitos).EjercitoListaUnidades.Count != 0) Console.WriteLine("Pulsa 3 para buscar un ejercito existente.");
            return int.Parse(Console.ReadLine());
        }

        public IMilitarizable BuscarEjercito()
        {
            string ColeccionNombres = "";
            Console.WriteLine("Introduce el nombre del ejercito a buscar");
            string NombreEjercito = Console.ReadLine();
            foreach(IMilitarizable Ejercito in ((IEjercito)this.GrupoEjercitos).EjercitoListaUnidades)
            {
                ColeccionNombres += $"\n{Ejercito.Titulo}";
                if(Ejercito.Titulo.Equals(NombreEjercito))return Ejercito;
            }
            Console.WriteLine($"Introduce un nombre de ejercito existente de entre estos nombres. \n{ColeccionNombres}");
            BuscarEjercito();
            return new EjercitoNuevo("", 0);
        }

        public IMilitarizable CrearEjercito()
        {
            string NombreEjercito = "";
            float Presupuesto = 0;
            bool NombreYaExistente = false;
            Console.WriteLine("Introduce el nombre del nuevo ejercito.");
            NombreEjercito = Console.ReadLine();
            foreach (IMilitarizable Ejercito in ((IEjercito)GrupoEjercitos).EjercitoListaUnidades)
            {
                if (Ejercito.Titulo.Equals(NombreEjercito)) {
                    Console.WriteLine("Ese Ejercito ya existe, introduce otro.");
                    NombreYaExistente = true;
                };
            }
            if(!NombreYaExistente)
            {
                Console.WriteLine("Introduce el presupuesto del nuevo ejercito.");
                Presupuesto = float.Parse(Console.ReadLine());
                return new EjercitoNuevo(NombreEjercito, Presupuesto);
            }
            if (NombreYaExistente) 
            {
                EjercitoNuevo Ejercito = (EjercitoNuevo)CrearEjercito();
                Presupuesto = Ejercito.Presupuesto;
            }
            return new EjercitoNuevo(NombreEjercito, Presupuesto);
        }
        public int OpcionesEjercito(IMilitarizable Ejercito)
        {
            int Comando = 0;
            Console.WriteLine("Introduce 1 para añadir una nueva unidad al ejercito.");
            Console.WriteLine("Introduce 2 para mostar información del ejercito.");
            if (((IEjercito)Ejercito).EjercitoListaUnidades.Count != 0) {
                Console.WriteLine("Introduce 3 para mostrar todas las unidades del ejercito.");
            }
            Console.WriteLine("Introduce 0 ir al menu de ejercito.");
            Comando = int.Parse(Console.ReadLine());
            return Comando;
        }

        public void MenuEjercito(IMilitarizable Ejercito)
        {
            int Comando = 0;
            Comando = OpcionesEjercito(Ejercito);
            switch (Comando) {
                case 1: Ejercito = CrearUnidad(Ejercito); 
                    break;
                case 2: Console.WriteLine(Ejercito.Mostrar());
                    break;
                case 3: ((IEjercito)Ejercito).MostrarUnidadesEjercito();
                    break;
            }
            if (Comando != 0) MenuEjercito(Ejercito);
        }

        public IMilitarizable CrearUnidad(IMilitarizable Ejercito)
        {
            string NombreUnidad = "";
            int Velocidad = 0;
            int Blindaje = 0;
            int PotenciaFuego = 0;
            float ElPrecio = 0;
            Console.WriteLine("Escribe el nombre de la unidad");
            NombreUnidad = Console.ReadLine();
            Console.WriteLine("Escribe la velocidad de la unidad");
            Velocidad = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el blindaje de la unidad");
            Blindaje = int.Parse(Console.ReadLine());

            Console.WriteLine("Escribe la potencia de fuego de la unidad");
            PotenciaFuego = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribe el precio de la unidad");
            ElPrecio = float.Parse(Console.ReadLine());
            if (((ICosteable)Ejercito).Precio + ElPrecio > (Ejercito as EjercitoNuevo).Presupuesto)
            {
                Console.WriteLine("Excede el presupuesto del ejercito, vuelve a generar una unidad con un precio menor o cero." 
                    + " Excedente:" + ((Ejercito as EjercitoNuevo).Presupuesto - ElPrecio));
                CrearUnidad(Ejercito);
            }
            IMilitarizable LaUnidadNueva = new Unidad(NombreUnidad, Velocidad, Blindaje, PotenciaFuego, ElPrecio);
            ((IEjercito)Ejercito).AddUnidad(LaUnidadNueva);
            return Ejercito;
        }
    }
}
