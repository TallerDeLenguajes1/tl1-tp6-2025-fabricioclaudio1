// See https://aka.ms/new-console-template for more information

using System.ComponentModel.DataAnnotations;

public class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
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
        
        //Ejercicio 4

        Console.WriteLine("Escribe un texto: ");
        string cadena = Console.ReadLine();

        int tamanio = cadena.Length;
        Console.WriteLine($"El tamanio de la cadena es: {tamanio}");

        Console.WriteLine("Escribe otro texto: ");
        string cadenaDos = Console.ReadLine();

        string cadenaTres = $"{cadena}{cadenaDos}";
        Console.WriteLine($"Cadenas concatenadas: {cadenaTres}");

        CalculadoraV1();

        foreach (char elemento in cadenaTres)
        {
            Console.WriteLine($"{elemento}");
        }

        Console.WriteLine("Busca una palabra en la cadena: ");
        string palabra = Console.ReadLine();
        if (cadenaTres.IndexOf(palabra) != -1)
        {
            Console.WriteLine("La palabra SI se encontro.");
        }
        else
        {
            Console.WriteLine("La palabra NO se encontro.");
        }
        Console.WriteLine($"Cadena a Mayusculas: {cadenaTres.ToUpper()}");
        Console.WriteLine($"Cadena a Minusculas: {cadenaTres.ToLower()}");

        string cadenaa = "Hola como estas";
        string[] cadenaSplit = cadenaa.Split(' ');
        foreach (string elemento in cadenaSplit)
        {
            Console.WriteLine(cadenaSplit);
        }

        Console.WriteLine("Ingrese una operacion para resolverla (ejemplo: 582+2): ");
        string operacionString = Console.ReadLine();
        string[] operacionSplit;
        int numA, numB;
        int result;
        if (operacionString.IndexOf('+') != -1)
        {
            operacionSplit = operacionString.Split('+');
            numA = NumeroEnteroV2(operacionSplit[0]);
            numB = NumeroEnteroV2(operacionSplit[1]);
            result = numA + numB;
            Console.WriteLine($"El resultado es: {result}");
        }
        else
        {
            if (operacionString.IndexOf('-') != -1)
            {
                operacionSplit = operacionString.Split('-');
                numA = NumeroEnteroV2(operacionSplit[0]);
                numB = NumeroEnteroV2(operacionSplit[1]);
                result = numA - numB;
                Console.WriteLine($"El resultado es: {result}");
            }
            else
            {
                if (operacionString.IndexOf('*') != -1)
                {
                    operacionSplit = operacionString.Split('*');
                    numA = NumeroEnteroV2(operacionSplit[0]);
                    numB = NumeroEnteroV2(operacionSplit[1]);
                    result = numA * numB;
                    Console.WriteLine($"El resultado es: {result}");
                }
                else
                {
                    if (operacionString.IndexOf('/') != -1)
                    {
                        operacionSplit = operacionString.Split('/');
                        numA = NumeroEnteroV2(operacionSplit[0]);
                        numB = NumeroEnteroV2(operacionSplit[1]);
                        result = numA / numB;
                        Console.WriteLine($"El resultado es: {result}");
                    }
                }
            }
        }



    //fin main
    }

    public static void CalculadoraV1()
    {
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
            select = NumeroEntero();

            if (select == 5)
            {
                Console.WriteLine("========================");
                return;
            }

            //Escribo los numeros para operar
            Console.WriteLine("Escribe los dos numeros: ");
            numA = NumeroEntero();
            Console.WriteLine("Ingrese el segundo numero: ");
            numB = NumeroEntero();


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
            Console.WriteLine($"La suma es: {num}");
        }

        void restar(int numA, int numB)
        {
            int num;
            num = numA - numB;
            Console.WriteLine($"La resta es: {num}");
        }

        void multiplicar(int numA, int numB)
        {
            int num;
            num = numA * numB;
            Console.WriteLine($"La multiplicacion es: {num}");
        }

        void dividir(int numA, int numB)
        {
            int num;
            num = numA / numB;
            Console.WriteLine($"La division es: " + num.ToString());
        }

        int realizarOtroCalculo()
        {

            Console.WriteLine(@"
=== ¿Desea realizar otro Calculo? ===
1. SI

0. NO
=====================================
");

            return NumeroEntero();
        }
    }

    public static int NumeroEntero()
    {

        int numero;

        while (true)
        {
            string numeroString = Console.ReadLine();
            bool resultado = int.TryParse(numeroString, out numero);
            if (resultado)
            {
                return numero;
            }
            else
            {

                Console.WriteLine("Lo que ingreso no es un numero, vuelve a intentarlo.");
            }
        }


    }

    public static int NumeroEnteroV2(string s)
    {

        int numero;

        while (true)
        {
            bool resultado = int.TryParse(s, out numero);
            if (resultado)
            {
                return numero;
            }
            else
            {

                Console.WriteLine("Error.");
            }
        }


    }




}