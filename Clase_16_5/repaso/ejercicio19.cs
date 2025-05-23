namespace repaso
{
    internal class ejecicio19
    {
        static void Main(string[] args)
        {
            //Escribir un programa que pida al usuario un año y determine si es

            int modulo4;
            int modulo100;
            int modulo400;
            int anio;

            Console.WriteLine("Ingrese un año");
            anio=int.Parse(Console.ReadLine());

            modulo4 = anio % 4;
            modulo100 = anio % 100;
            modulo400 = anio % 400;

            //bisiesto. Un año es bisiesto si es divisible entre 4, pero no entre 100,
            //a menos que también sea divisible entre 400.

            if ((modulo4==0 && modulo100!=0 )|| modulo400==0 )
            {
                Console.WriteLine("es bisiesto");
            }
            else
            {
                Console.WriteLine("no es bisiesto");
            }

        }
    }
}
