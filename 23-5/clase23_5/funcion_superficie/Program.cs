//solicitar al usuario que ingrese la base y altura de un rectangulo y crear dos funciones:

int base_rectangulo;
int altura_rectangulo;

Console.WriteLine("Base del rectangulo: ");
base_rectangulo = int.Parse(Console.ReadLine());

Console.WriteLine("Altura del rectangulo: ");
altura_rectangulo = int.Parse(Console.ReadLine());

Console.WriteLine(CalcularSuperficie(base_rectangulo, altura_rectangulo));
Console.WriteLine($"El perimetro es {CalcularPerimetro(base_rectangulo, altura_rectangulo)}");

// -Una que calcule la superficie de un rectangulo b*h
string CalcularSuperficie(int dato_base, int dato_altura)
{
    int superficie;
    superficie = dato_base * dato_altura;

    //return dato_base*dato_altura;
    return "La superficie es" + superficie;
}

// -otra que calcule el perimetro 2*b+2*h
int CalcularPerimetro(int dato_base, int dato_altura)
{
    int perimetro;
    perimetro = 2 * dato_base + 2 * dato_altura;

    return perimetro;
}

