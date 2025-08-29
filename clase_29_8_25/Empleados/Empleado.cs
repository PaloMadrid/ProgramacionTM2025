using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Empleados
{
    class Empleado
    {
        public string Nombre {  get; set; }
        public double Salario { get; set; }
        public string Departamento {  get; set; }
        public int Antiguedad {  get; set; }    


        public virtual void MostrarDatos()
        {
            Console.WriteLine( $"nombre: {Nombre}\nSalario: {Salario}\nDepartamento: {Departamento}\nAntigüedad: {Antiguedad}");
        }


        //otra forma de crear el metodo para mostrar los datos. importante: si usamos esta forma, los metodos de las clases derivadas tambien tienen que retornar un string


        //public virtual string MostrarDatos()
        //{
        //    return $"nombre: {Nombre}\nSalario: {Salario}\nDepartamento: {Departamento}\nAntigüedad: {Antiguedad}";
        //}


        //////opcionales

        //Atributos:

        //private string nombre;
        //private double salario;
        //private string departamento;
        //private int antiguedad;






        //Metodo constructor


        //public Empleado(string nombre, double salario, string departamento, int antiguedad)
        //{
        //    this.nombre = nombre;
        //    this.salario = salario;
        //    this.departamento = departamento;
        //    this.antiguedad = antiguedad;
        //}
    }
}
