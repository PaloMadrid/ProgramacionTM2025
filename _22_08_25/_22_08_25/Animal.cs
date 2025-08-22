using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_08_25
{
     class Animal
    {
        //declaracion de atributos
        private string nombre;
        private int cantidad_de_patas;
        private string tipo;

        //constructor
        public Animal(string nombreDelBicho, int cantidad_patas, string tipo)
        {
            this.Nombre = nombreDelBicho;
            this.Cantidad_de_patas = cantidad_patas;
            this.Tipo = tipo;
        }

        //metodos get set
        public string Nombre { get ; set ; }
        public int Cantidad_de_patas { get ; set ; }
        public string Tipo { get ; set ; }

        //metodo de accion

        public void ComerVoid()
        {
            Console.WriteLine( Nombre + " esta comiendo.");
        }

        public void MostrarDatos()
        {
            //no puedo usar este metodo para ingresar informacion, solo para mostrarla
            Console.WriteLine("La mascota ingresada se llama "+Nombre+ " es de tipo "+Tipo+" y tiene "+Cantidad_de_patas+" patas");
        }
    }
}
