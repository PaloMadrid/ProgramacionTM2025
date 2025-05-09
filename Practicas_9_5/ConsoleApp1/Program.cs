namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //escribir aca
            //Realizar un programa que calcule la superficie de un triángulo dada su altura
            //y base

            //b*h/2
            //declaracion de variables
            double base_triangulo;
            double altura;
            //admite decimales
            double resultado;

            //ingreso de datos
            Console.WriteLine("Ingrese la base del triangulo");
            base_triangulo =double. Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la altura del triangulo");
            altura = double.Parse(Console.ReadLine());

            //procesos
            //los datos con los que hago la cuenta tienen que admitir decimales tambien
            resultado = base_triangulo * altura / 2;

            Console.WriteLine("la superficie del triangulo de base " + base_triangulo + " y altura " + altura + " es de " + resultado);

        }
    }
}
