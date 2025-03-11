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

/*
static void Saludar(string nombre, int edad)
{
    Console.WriteLine("Te llamas " + nombre + " y tienes " + edad + "años");
}

string persona = "Juan";
Saludar(persona, 23);
Saludar("Pedro", 24);
*/

/*
static double Media(double num1, double num2)
{
    double resultado = (num1 + num2) / 2;
    return resultado;
}

double valorMedio = Media(8.0, 4.0);
Console.WriteLine(valorMedio);
*/

/*
bool valorBooleano = false;

bool valorBooleano1 = 8 > 3;
Console.WriteLine(valorBooleano1);
bool valorBooleano2 = 8 > 8;
Console.WriteLine(valorBooleano2);
bool valorBooleano3 = 8 == 8;
Console.WriteLine(valorBooleano3);
bool valorBooleano4 = 8 != 8;
Console.WriteLine(valorBooleano4);
bool valorBooleano5 = (0 != 5) && (8 < 3);
Console.WriteLine(valorBooleano5);
bool valorBooleano6 = (0 != 5) || (8 < 3);
Console.WriteLine(valorBooleano6);
*/

/*
int num = 10;
if (num % 2 == 0)
{
    Console.WriteLine("eL NUMERO  " + num + " es par");
}
else
{
    Console.WriteLine("El numero  " + num + " es impar");
}

int num1 = 11;
int num2 = 12;
if (num1 > num2)
{
    Console.WriteLine("El numero " + num1  + " es mayor que" + num2);
} else if (num1 < num2)
{
    Console.WriteLine("El numero " + num2 + "ES MAYOR QUE " + num1);
}
else
{
    Console.WriteLine("Ambos numeros son iguales");
}
*/

/*
int mes = 1;
switch(mes)
{
    case 1: Console.WriteLine("El primer mes es enero");
        break;
    case 2: Console.WriteLine("El segundo mes es febrerp");
        break;
    case 3: Console.WriteLine("El tercer mes es marzo");
        break;
    case 4: Console.WriteLine("El cuarto mes es abril");
        break;
    case 5: Console.WriteLine("El quinto mes es mayo");
        break;
    case 6: Console.WriteLine("El sexto mes es junio");
        break;
    case 7: Console.WriteLine("El septimo mes es julio");
        break;
    case 8: Console.WriteLine("El octavo mes es agosto");
        break;
    case 9: Console.WriteLine("El noveno mes es septiembre");
        break;
    case 10: Console.WriteLine("El decimo mes es octubre");
        break;
    case 11: Console.WriteLine("El onceavo mes es noviembre");
        break;
    case 12: Console.WriteLine("El doceavo mes es diciembre");
        break;
    default: Console.WriteLine("Mes incorrecto");
        break;
}
*/

/*
double num = 10.0;
while (num >= 0)
{
    Console.WriteLine(num);
    num = num / 2;
}

double num1 = 0.8;
do
{
    Console.WriteLine(num1);
    num1 = num1 / 2;
} while(num1 >= 1);
*/

/*
for (int i = 1; i<= 10; i++)
{
    Console.WriteLine(i);
}
*/

/*
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}

for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}
*/

/*
int[] numeros = [8, 2, 6, 11, 16];
for (int i = 1; i <= 10; i++)
{
    Console.WriteLine(numeros[i]);
}
*/

/*

int[,] numeros = { { 11, 12, 13 }, { 21, 22, 23 }, { 31, 32, 33 } };
for (int j = 0; j < 3; j++)
{
    for (int i = 0; i < 3; i++)
    {
        Console.WriteLine(numeros[j, i]);
    }
}
*/

/*
using c_;

Alumno alumno1 = new Alumno("Juan", 25, 7.2, "Arquitectura");
Console.WriteLine(Alumno.alumnosTotales);
Alumno alumno2 = new Alumno("Laura", 23, 7.9, "Ingeniería");
Console.WriteLine(Alumno.alumnosTotales);
Alumno alumno3 = new Alumno("Juan", 25, 7.2, "Arquitectura");
Console.WriteLine(Alumno.alumnosTotales);
Alumno alumno4 = new Alumno("Laura", 23, 7.9, "Ingeniería");
Console.WriteLine(Alumno.alumnosTotales);



Console.WriteLine("El alumno " + alumno1.nombre + " cursa el grado en " + alumno2.grado);

Console.WriteLine(alumno1.Aprobado());
Console.WriteLine(alumno2.Aprobado());
Console.WriteLine(Alumno.alumnosTotales);
Frases.Saludar();
Frases.Despedida();
Frases frase1 = new Frases();
*/

using c_;

Animal animal1 = new Animal();
Perro perro1 = new Perro();

animal1.Comer();
animal1.Dormir();

perro1.Comer();
perro1.Dormir();
perro1.Ladrar();

animal1.Comer();
perro1.Comer();