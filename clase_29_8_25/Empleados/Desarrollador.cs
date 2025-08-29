using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    internal class Desarrollador : Empleado
    {
        public string LneguajeProgramacion {  get; set; }
        public string Jerarquia { get; set; }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"Lneguaje Programacion: {LneguajeProgramacion}\nJerarquia: {Jerarquia}");
        }



        //////opcionales

        //atributos:

        //private string LenguajeProgramacion;
        //private string jerarquia;

        //metodo constructor herencia

        //public Desarrollador(string lenguajeProgramacion, string jerarquia, string nombre, double salario, string departamento, int antiguedad) : base(nombre, salario, departamento, antiguedad)
        //{
        //    this.lenguajeProgramacion = lenguajeProgramacion;
        //    this.jerarquia = jerarquia;
        //}

    }
}
