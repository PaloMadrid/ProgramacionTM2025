namespace funcion_saludar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //funcion que ingresa un nombre y lo saluda
            string nombre;
            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();


            

        }

        //Zona donde se definen las funciones

        static string Saludar(string nombre)
        {
            return $"Hola {nombre}";
        }
    }
}
