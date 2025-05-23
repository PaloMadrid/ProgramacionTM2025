namespace ejemplo_while
{
    internal class repetitivas
    {
        static void Main(string[] args)
        {
            int contador = 0;
            int contador_DW=0;

            //con mientras (while)
            while (contador < 10/*condicion de corte*/)
            {
                //procesos mientras se este repitiendo

                //contador=contador+1;
                //contador += 1;
                contador++;

                Console.WriteLine("con while "+contador);
            }

            //con para (for)

            for (int i = 1; i <= 10; i++)
            //(variable que se utiliza para contabilizar vueltas. solo se puede usar dentro del for
            //cuantas repeticiones necesito
            //paso de uno en uno
            {
                Console.WriteLine("con for "+i);
            }

            //repetir mientras que
            do
            {
                contador_DW++;
                Console.WriteLine("con do while: "+contador_DW);

            } while (contador_DW < 10); 
            //(condicion de corte)

        }
    }
}
