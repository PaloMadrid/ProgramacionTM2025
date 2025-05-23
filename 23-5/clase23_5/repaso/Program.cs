namespace repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //            Una biblioteca desea registrar los títulos de los libros que tiene en una
            //            estantería.
            //            El usuario debe:
            //            Ingresar cuántos libros quiere registrar.
            //Ingresar el título de cada libro.

            int cantidad_libros;

            List<string> libros = new List<string>
            {
                "100 años de soledad",
                "boquitas pintadas",
                "el principito",
                "el quijote"
            };

            Console.WriteLine("Cuantos libros desea cargar?");
            cantidad_libros = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidad_libros; i++)
            {
                Console.WriteLine("Titulo: ");
                libros.Add(Console.ReadLine());
            }

            //Luego, ingresar un título para buscar si está en la estantería.
            //Mostrar un mensaje si se encuentra, indicando su posición.
            //Si no está, mostrar un mensaje diciendo que el libro no se encontró.

            Console.WriteLine("Que titulo desea buscar?");
            string titulo = Console.ReadLine();
            
            //todos en mayusculas .ToUpper() - todo en minusculas .ToLower()- Primera mayuscula y las siguientes minuscula


            if (libros.Contains(titulo.ToLower()))
            {
                for (int i = 0; i < libros.Count; i++)
                {
                    if (libros[i] == titulo.ToLower())
                    {
                        Console.WriteLine($"El libro {titulo} se encontro en la posicion {i}");
                        break;
                    }
                }
            }else
            {
                Console.WriteLine("No se encontro el titulo");
            }
        }
    }
}
