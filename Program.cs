// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

//Ejercicio 3


string numeroString;
float numero = 0;
bool resultado;

int select = 1;
while (select != 0)
{
    Console.WriteLine("Ingrese un numero: ");
    numeroString = Console.ReadLine();
    resultado = float.TryParse(numeroString, out numero);
    if (resultado)
    {
        select = 0;
    }
    else
    {
        Console.WriteLine("Lo que ingreso no es un numero, intentelo de nuevo");
        select = 1;
    }
}
Console.WriteLine(@$"
========================
El numero es {numero}
Valor Absoluto: {Math.Abs(numero)}
El cuadrado: {numero * numero}
La raíz cuadrada: {Math.Sqrt(numero)}
El seno: {Math.Sin(numero)}
El coseno: {Math.Cos(numero)}
La parte entera de un tipo float: {(int)numero}
========================
");

//Segunda Parte de Calculadora v2
Console.WriteLine("Ingrese dos numeros: ");

int Minimo = IngresarNumero();
Console.WriteLine(@$"
Numero ingresado: {Minimo} 
Ingrese el otro numero: 
");
int Maximo = IngresarNumero();
Console.WriteLine(@$"
Numero ingresado: {Maximo} 
");

int aux = 0;
if (Minimo > Maximo)
{
    Minimo = aux;
    Minimo = Maximo;
    Maximo = aux;
}

int longitud = Maximo - Minimo;
if (longitud == 0)
{
    Console.WriteLine(@$"
Numero Maximo y Minimo es: {Maximo} 
");
}
else if (longitud == 1)
{
    Console.WriteLine(@$"
Numero Maximo es: {Maximo} 
Numero Minimo es: {Minimo} 
");
}
else if (longitud == 2)
{
    Console.WriteLine(@$"
Numero Maximo y Minimo es: {Maximo - 1} 
");
}
else if (longitud > 2)
{
    Console.WriteLine(@$"
Numero Maximo es: {Maximo - 1} 
Numero Minimo es: {Minimo + 1} 
");
}



int IngresarNumero()
{
    int select = 1;

    while (select != 0)
    {
        numeroString = Console.ReadLine();
        resultado = float.TryParse(numeroString, out numero);
        if (resultado)
        {
            select = 0;
        }
        else
        {
            Console.WriteLine("Lo que ingreso no es un numero, intentelo de nuevo");
            select = 1;
        }
    }

    return (int)numero;
}
