// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string nombre = "Pedro";
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

//concatenacion

string texto1 = "Hola";
string texto2 = "Mujndo";
string texto = string.Concat(texto1, " ",    texto2);
Console.WriteLine(texto[0]);