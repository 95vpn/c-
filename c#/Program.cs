// See https://aka.ms/new-console-template for more information

/*Console.WriteLine("Hello, World!");

//string nombre = "Pedro";
int edad = 40;
Console.WriteLine("Me llamo " + nombre + " y tengo " + edad + " años");
Console.WriteLine("Tengo " + edad + " años y me llamo " + nombre);
edad = edad + 1;
Console.WriteLine("El año que viene tendrá " + edad + " años");

int numeroEntero = 5;
double numeroDecimal = 16.0;
//string texto = "lopju ";
char letra = 'A';
bool aprobado = true;
*/

/*
//concatenacion

string texto1 = "Hola";
string texto2 = "Mujndo";
string texto = string.Concat(texto1, " ",    texto2);
Console.WriteLine(texto[0]);

string nombre = "Juan";
string apellido = "Perex";
string frase = "Mi nombre es " + nombre + "y mi apellido es " + apellido;
string frase1 = $"Mi nombre es {nombre} y mi apellido es {apellido}";

Console.WriteLine(frase.Length);
Console.WriteLine(frase1.ToUpper());
Console.WriteLine(frase1.ToLower());
Console.WriteLine(frase1.Contains("J"));
Console.WriteLine(frase1.IndexOf("J"));
Console.WriteLine(frase1.Substring(10, 10));
*/

/*
//numeros
int numero = 10;
double numero2 = 2.5;
Console.WriteLine(4/2);
Console.WriteLine(5 % 2);
Console.WriteLine(8 /3);
Console.WriteLine(8.0 /3.0);
Console.WriteLine(numero);
numero++;
Console.WriteLine(numero);
Console.WriteLine(Math.Abs(-5)); 
Console.WriteLine(Math.Pow(2,5));
Console.WriteLine(Math.Sqrt(9));
Console.WriteLine(Math.Ceiling(5.4));
Console.WriteLine(Math.Floor(5.9));
Console.WriteLine(Math.Max(10, 15));
*/

/*
Console.WriteLine("introsuce tu nombre");
string nombre = Console.ReadLine();
Console.WriteLine("Tu nombre es " +nombre);
Console.WriteLine("Introduce tu edad");
int edad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Tu nombre es " + nombre + " y tu edad es: " + edad);
*/

/*

string nombre1 = "Pablo";
string nombre2 = "Laura";
string[] nombres = { "Pablo", "Laura", "Pedro" };
double[] notas = { 7.2, 4.0, 3.2 };
bool[] aprobado = { true, false, false };
int[] edades = new int[3];
edades[0] = 56;
edades[1] = 75;
edades[2] = 52;
Console.WriteLine(nombres[0]);
Console.WriteLine(edades[1]);
*/

/*
try
{
    int[] nums = { 1, 2, 3, 4, 5, 6 };
    Console.WriteLine(nums[5]);    
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
finally
{
     Console.WriteLine("El programa finaliza aquí");
}
*/

static void Saludar(string nombre, int edad)
{
    Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + "años");
}

string persona = "Juan";
Saludar(persona, 23);