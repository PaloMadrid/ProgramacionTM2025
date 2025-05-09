// See https://aka.ms/new-console-template for more information
//pedir un sueldo bruto y calcular cuanto tiene que aportar,
//siendo 11% jubilacion 3% obra social 3% pami
//mostrar cuanto debe aportar de cada descuento y el salario neto

using System.Globalization;

//declaracion 
double salario_bruto;
double jubilacion;
double pami;
double osoc;
double salario_neto;

//ENTRADA DE DATOS
Console.WriteLine("Ingrese el salario bruto");
salario_bruto=double.Parse(Console.ReadLine());

//procesos
jubilacion = salario_bruto * 0.11;
pami = salario_bruto * 0.03;
osoc = pami;
salario_neto=salario_bruto-jubilacion-pami-osoc;

//salida de datos
Console.WriteLine("jubilacion: " + jubilacion);
Console.WriteLine("pami: "+pami);
Console.WriteLine("Obra social: " + osoc);
Console.WriteLine("salario neto: " + salario_neto);

// \n inserta un salto de linea 
Console.WriteLine($"(Con contrabarra y n )\njubilacion: {jubilacion}\nPAMI: {pami}");