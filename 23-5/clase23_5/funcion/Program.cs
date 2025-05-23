// See https://aka.ms/new-console-template for more information
string nombre;
int edad;
Console.WriteLine("Ingrese su nombre");
nombre = Console.ReadLine();

Console.WriteLine("Cuantos años tenes?");
edad =int.Parse( Console.ReadLine());

Console.WriteLine(Saludar(nombre,edad));

//tipo de dato que va a retornar - nombre de funcion  (parametros datos necesarios para la funcion)
string Saludar(string dato, int anios)
{
    return $"Hola {dato}, tenes {anios} años";
}