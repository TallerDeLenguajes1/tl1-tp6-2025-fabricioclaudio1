// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
int a;
int b;
a=10;
b=a;
Console.WriteLine("valor de a:"+a);
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
