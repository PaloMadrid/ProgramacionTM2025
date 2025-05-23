namespace ejercicio23
{
    internal class ejercicio23
    {
        static void Main(string[] args)
        {
            //Escribe un programa que pregunte al usuario su nota en un examen y su asistencia,
            //y muestre un mensaje según la nota y la asistencia:

            int nota;
            int asistencia;
            string mensajeSalida="";

            Console.WriteLine("nota: ");
            nota=int.Parse(Console.ReadLine());

            Console.WriteLine("% de asistencia: ");
            asistencia=int.Parse(Console.ReadLine());

            //Si la nota es mayor o igual que 4 y la asistencia es mayor o igual que 80 %,
            //mostrar "Aprobaste con buena asistencia".

            //Si la nota es mayor o igual que 4 y la asistencia es menor que 80 %,
            //mostrar "Aprobaste con mala asistencia".
                //Si la nota es menor que 4 y la asistencia es mayor o igual que 80 %,
                //mostrar "Reprobaste con buena asistencia".
                //Si la nota es menor que 4 y la asistencia es menor que 80 %,
                //mostrar "Reprobaste con mala asistencia".
            if (nota>=4 && asistencia>=80)
            {
                mensajeSalida = "Aprobaste con buena asistencia";

            }else if (nota>=4 && asistencia<80)
            {
                mensajeSalida = "Aprobaste con mala asistencia";
            }else if( asistencia>=80)
            {
                mensajeSalida = "Reprobaste con buena asistencia";
            }
            else
            {
                mensajeSalida = "Reprobaste con mala asistencia";
            }
            Console.WriteLine(mensajeSalida+". nota: "+nota+" - asistencia: "+asistencia+"%");

            //Console.WriteLine($"{mensajeSalida}. Nota: {nota} - Asistencia: {asistencia}%");
            
            





       
        }
    }
}
