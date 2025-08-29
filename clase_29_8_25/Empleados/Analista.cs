using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empleados
{
    class Analista : Empleado
    {
        public string Especialidad {  get; set; }
        public string Proyectos {  get; set; }

        public override void MostrarDatos()
        {
            base.MostrarDatos();
            Console.WriteLine($"especialidad: {Especialidad}\nProyectos: {Proyectos}");
        }




        //////opcionales

        //atributos:

        //private string especialidad;
        //private string proyectos;

        //metodo constructor herencia

        //public Analista(string especialidad, string proyectos, string nombre, double salario, string departamento, int antiguedad) : base(nombre, salario, departamento, antiguedad)
        //{
        //    this.especialidad = especialidad;
        //    this.proyectos = proyectos;
        //}
    }
}
