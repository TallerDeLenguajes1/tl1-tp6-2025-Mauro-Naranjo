// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int a;
int b;
a = 10;
b = a;
Console.WriteLine("valor de a:" + a);
Console.WriteLine("valor de b:" + b);

string? numeroString;
int numero;
Console.WriteLine("ingrese un numero");
numeroString = Console.ReadLine();
bool resultado = int.TryParse(numeroString, out numero);

int Digito;
string numInver = "";
if (resultado && numero > 0)
{
    do
    {
        Digito = numero % 10;
        numero = numero / 10;
        numInver = numInver + Digito;
    } while (numero > 0);  
}

Console.WriteLine("El numero invertido es: " + numInver);

//ejercicio 2
bool continuar = true;

while (continuar)
{
    Console.WriteLine("Ingrese la operacion a realizar");
    Console.WriteLine("1. Sumar");
    Console.WriteLine("2. Restar");
    Console.WriteLine("3. Multiplicar");
    Console.WriteLine("4. Dividir");

    string? opcion = Console.ReadLine();

    Console.WriteLine("Ingrese el primer numero a operar: ");
    string? numero1 = Console.ReadLine();
    Console.WriteLine("Ingrese el segundo numero a operar: ");
    string? numero2 = Console.ReadLine();


    if (float.TryParse(numero1, out float num1) && float.TryParse(numero2, out float num2))
    {
        switch (opcion)
        {
            case "1":
                Console.WriteLine("El resultado es: " + (num1 + num2));
                break;
            case "2":
                Console.WriteLine("El resultado es: " + (num1 - num2));
                break;
            case "3":
                Console.WriteLine("El resultado es: " + (num1 * num2));
                break;
            case "4":
                Console.WriteLine("El resultado es: " + (num1 / num2));
                break;
            default:
                Console.WriteLine("La opcion ingresada es incorrecta");
                break;
        }
    }
    else
    {
        Console.WriteLine("Los numeros ingresados son invalidos");
    }

    Console.WriteLine("Desea realizar otra operacion? (s/n): ");
    string? respuesta = Console.ReadLine();
    if (respuesta?.ToLower() != "s")
    {
        continuar = false;
    }
}
//ejercicio 3

Console.WriteLine("Ingrese un numero: ");
string? numero3 = Console.ReadLine();

if (double.TryParse(numero3, out double num3))
{
    Console.WriteLine("Valor absoluto = " + Math.Abs(num3));
    Console.WriteLine("Cuadrado = " + Math.Pow(num3, 2));
    if (num3 >= 0)
    {
        Console.WriteLine("Raiz Cuadrada = " + Math.Sqrt(num3));
    }
    else
    {
        Console.WriteLine("No se puede calcular la raiz cuadrada de un numero negativo");
    }
    Console.WriteLine("Seno = " + Math.Sin(num3));
    Console.WriteLine("Coseno = " + Math.Cos(num3));
    Console.WriteLine("Parte entera = " + Math.Truncate(num3));
}
else
{
    Console.WriteLine("No ingresó un numero válido");
}

Console.WriteLine("Ingrese el primer numero a comparar: ");
string? numero4 = Console.ReadLine();
Console.WriteLine("Ingrese el segundo numero a comparar: ");
string? numero5 = Console.ReadLine();

if (double.TryParse(numero4, out double num4) && double.TryParse(numero5, out double num5))
{
    Console.WriteLine("El maximo es: " + Math.Max(num4, num5));
    Console.WriteLine("El minimo es: " + Math.Min(num4, num5));
}
else
{
    Console.WriteLine("No ingresó numeros válidos");
}