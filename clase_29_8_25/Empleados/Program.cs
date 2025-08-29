namespace Empleados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Analista empleado=new Analista();

            empleado.Nombre = "Juan";
            empleado.Salario = 1000000;
            empleado.Departamento = "Atencion al publico";
            empleado.Antiguedad = 6;
            empleado.Especialidad = "Datos";
            empleado.Proyectos = "clinica";
            empleado.MostrarDatos();

            ////misma construccion de objetos pidiendo al usuario que cargue los datos

            //Empleado empleado1 = new Empleado();

            //Console.WriteLine("Nombre?");
            //empleado1.Nombre = Console.ReadLine();
            //Console.WriteLine("Salario?");
            //empleado1.Salario =double.Parse( Console.ReadLine());
            //Console.WriteLine("departamento?");
            //empleado1.Departamento = Console.ReadLine();
            //Console.WriteLine("antiguedad?");
            //empleado1.Antiguedad=int.Parse( Console.ReadLine());

            ////metodo de clase empleado que muestra datos
            //empleado1.MostrarDatos();










        }
    }
}
