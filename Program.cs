// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
<<<<<<< HEAD
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);
=======

//Ejercicio 3
>>>>>>> CalculadoraV2


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

//Calculadora v1

int select = 1;
int numA, numB;

while (select != 0)
{
    Console.WriteLine(@"
=== MENÚ CALCULADORA ===
1. Sumar
2. Restar
3. Multiplicar
4. Divir

5. Salir
========================
");
    //Elijo opcion
    select = Console.Read();

    //Escribo los numeros para operar
    Console.WriteLine("Escribe los dos numeros: ");
    numA = Console.Read();
    numB = Console.Read();

    switch (select)
    {
        case 1:
            {
                sumar(numA, numB);
                select = realizarOtroCalculo();

                break;
            }
        case 2:
            {
                restar(numA, numB);
                select = realizarOtroCalculo();

                break;
            }
        case 3:
            {
                multiplicar(numA, numB);
                select = realizarOtroCalculo();

                break;
            }
        case 4:
            {
                dividir(numA, numB);
                select = realizarOtroCalculo();


                break;
            }
        case 5:
            {
                select = 0;

                break;
            }
    }

}

void sumar(int numA, int numB)
{
    int num;
    num = numA + numB;
}

void restar(int numA, int numB)
{
    int num;
    num = numA - numB;
}

void multiplicar(int numA, int numB)
{
    int num;
    num = numA * numB;
}

void dividir(int numA, int numB)
{
    int num;
    num = numA / numB;
}

int realizarOtroCalculo()
{

    Console.WriteLine(@"
=== ¿Desea realizar otro Calculo? ===
1. SI

0. NO
=====================================
");

    return Console.Read();
}