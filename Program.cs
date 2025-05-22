// See https://aka.ms/new-console-template for more information

using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);


//Ejercicio 1
string numeroString = Console.ReadLine();
int numero;

bool resultado = int.TryParse(numeroString, out numero);

if (resultado)
{
    float num = (float)1 / numero;
    Console.WriteLine($"1/{numero}");
    Console.WriteLine(num);
}
else
{
    Console.WriteLine("Lo que ingreso no es un numero.");
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