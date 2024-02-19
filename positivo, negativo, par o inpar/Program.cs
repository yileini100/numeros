// See https://aka.ms/new-console-template for more information
Console.WriteLine("determina el numero");

// Solicitar al usuario ingresar la cantidad de números a evaluar
Console.WriteLine("Ingrese la cantidad de números a evaluar:");
int n = Convert.ToInt32(Console.ReadLine());

int positivos = 0;
int negativos = 0;
int pares = 0;
int impares = 0;

// Leer los números y realizar el conteo correspondiente
for (int i = 0; i < n; i++)
{
    Console.WriteLine("Ingrese el número " + (i + 1) + ":");
    int numero = Convert.ToInt32(Console.ReadLine());

    if (numero > 0)
        positivos++;
    else if (numero < 0)
        negativos++;

    if (numero % 2 == 0)
        pares++;
    else
        impares++;
}

// Mostrar los resultados en pantalla
Console.WriteLine("Cantidad de números positivos: " + positivos);
Console.WriteLine("Cantidad de números negativos: " + negativos);
Console.WriteLine("Cantidad de números pares: " + pares);
Console.WriteLine("Cantidad de números impares: " + impares);
