// See https://aka.ms/new-console-template for more information
using _22_08_25;

Console.WriteLine("Hello, World!");

string nombre_animal1 = "";
string tipo_animal1;
int cantidad_patas_animal1;

Console.WriteLine("Ingrese el nombre de la mascota:");
nombre_animal1 = Console.ReadLine();

Console.WriteLine("Ingrese el tipo de mascota:");
tipo_animal1 = Console.ReadLine();

Console.WriteLine("Ingrese la cantidad de patas:");
cantidad_patas_animal1 = int.Parse(Console.ReadLine());

Animal animal1 = new Animal(nombre_animal1, cantidad_patas_animal1, tipo_animal1);
Animal animal2 = new Animal("Doggy",4,"Perro");

animal1.MostrarDatos();

animal2.MostrarDatos();

animal2.ComerVoid();