//con instrucciones de nivel superior

using System.Runtime.InteropServices.ObjectiveC;

//declarar variables
string nombre;
int edad;

//mostrar mensaje en pantalla
Console.WriteLine("Por favor ingrese su nombre: ");
//guardar el valor en una variable
nombre=Console.ReadLine();

Console.WriteLine("Ingrese su edad: ");
edad=int.Parse(Console.ReadLine());


//salida de datos
Console.WriteLine($"Su nombre es {nombre} y tiene {edad} años");

//otra forma de mostrar los datos
//Console.WriteLine("Su nombre es " + nombre);