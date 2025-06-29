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

//ejercicio 4

//Obtener la longitud de la cadena y muestre por pantalla
Console.WriteLine("Ingrese una frase: ");
string frase = Console.ReadLine();
Console.WriteLine($"La longitud de la frase es: {frase.Length}");

//A partir de una segunda cadena ingresada por el usuario, concatene ambas cadenas distintas
Console.WriteLine("Ingrese otra frase para concatenar: ");
string frase2 = Console.ReadLine();
string concatenadas = string.Concat(frase, " ", frase2);
Console.WriteLine($"Cadenas concatenadas : {concatenadas}");

//Extraer una subcadena
Console.WriteLine("Ingrese la posicion en la que desea extraer la subcadena: ", frase.Length - 1);
string? posIni = Console.ReadLine();
Console.WriteLine("Ingrese la cantidad de caracteres a extraer: ");
string? cant = Console.ReadLine();
if (int.TryParse(posIni, out int inicio) && int.TryParse(cant, out int cantidad))
{
    string subcadena = frase.Substring(inicio, cantidad);
    Console.WriteLine($"Subcadena: {subcadena}");
}

//Suma y muestra por pantalla
Console.WriteLine("Ingrese un numero: ");
string? numero6 = Console.ReadLine();
Console.WriteLine("Ingrese el segundo numero a sumar: ");
string? numero7 = Console.ReadLine();
if (double.TryParse(numero6, out double num6) && double.TryParse(numero7, out double num7))
{
    double suma = num6 + num7;
    Console.WriteLine($"{num6} + {num7} = {suma}");
}

//Recorrer cadena de texto
Console.WriteLine("Caracteres en la primer cadena: ");
foreach (char c in frase)
{
    Console.WriteLine(c);
}

//Buscar la ocurrencia de una palabra
Console.WriteLine("Caracteres en la primera cadena: ");
string palabra = Console.ReadLine();
bool contiene = frase.Contains(palabra);
if (contiene)
{
    Console.WriteLine($"La palabra '{palabra}' está en la cadena");
}
else
{
    Console.WriteLine($"La palabra '{palabra}' no fue encontrada en la cadena");
}

//Convertir a mayusculas y luego a minusculas
Console.WriteLine($"Convertida a mayusculas: {frase.ToUpper()}");
Console.WriteLine($"Convertida a minusculas: {frase.ToLower()}");

//cadena separada con caracteres que yo determino
Console.Write("Ingrese una cadena separada por '-': ");
string separada = Console.ReadLine();
string[] partes = separada.Split('-');
Console.WriteLine("Las partes de la cadena son: ");
foreach (string parte in partes)
{
    Console.WriteLine(parte);
}

//Resolver una ecuacion simple
Console.WriteLine("Ingrese una ecuacion simple como '582 + 2': ");
string ecuacion = Console.ReadLine();

char[] operadores = { '+', '-', '*', '/' };
char operador = ' ';
foreach (char ope in operadores)
{
    if (ecuacion.Contains(ope))
    {
        operador = ope;
        break;
    }
}

if (operador != ' ')
{
    string[] operandos = ecuacion.Split(operador);
    if (operandos.Length == 2 && double.TryParse(operandos[0], out double ope1) && double.TryParse(operandos[1], out double ope2))
    {
        double total = 0;
        switch (operador)
        {
            case '+':
                total = ope1 + ope2;
                break;
            case '-':
                total = ope1 - ope2;
                break;
            case '*':
                total = ope1 * ope2;
                break;
            case '/':
                if (ope2 != 0)
                {
                    total = ope1 / ope2;
                }
                else
                {
                    Console.WriteLine("No se puede dividir por 0");
                }
                break;

        }
        Console.WriteLine($"El total de {ecuacion} es: {resultado}");
    }
} else
{
    Console.WriteLine("La ecuacion no es valida");
}