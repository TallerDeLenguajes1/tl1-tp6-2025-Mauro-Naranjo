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