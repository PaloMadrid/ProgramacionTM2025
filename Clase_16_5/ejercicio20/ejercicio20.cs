namespace ejercicio20
{
    internal class ejercicio20
    {
        static void Main(string[] args)
        {
            string color;
            string mensaje;

            Console.WriteLine("Ingrese un color del semaforo");
            color= Console.ReadLine();

            switch (color)
            {
                case "verde":
                    mensaje = "Puede pasar";
                    break;
                case "amarillo":
                    mensaje = "precaucion";
                    break;
                case "rojo":
                    mensaje = "alto";
                    break;
                default:
                    mensaje = "no corresponde a un color del semaforo";
                    break;

            }

            Console.WriteLine(mensaje);


        }
    }
}
