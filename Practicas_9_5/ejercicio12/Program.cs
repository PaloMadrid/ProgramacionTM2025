namespace ejercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribe un programa que al Ingresar una
            //edad muestre un mensaje que muestre si es mayor o menor de edad

            int edad;
            string mensaje;

            Console.WriteLine("Edad: ");
            edad=int.Parse(Console.ReadLine());

            if (edad>=18/*condicion*/)
            {
                //procesos que necesito hacer en caso de true
                mensaje = "Es mayor de edad";
            }
            else
            {
                mensaje = "Es menor de edad";
            }

            Console.WriteLine(mensaje);




        }
    }
}
