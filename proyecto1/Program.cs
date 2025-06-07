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
