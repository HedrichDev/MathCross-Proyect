using System;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese un número mamahuevo: ");
        int numero = int.Parse(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("El número es par.");
        }
        else
        {
            Console.WriteLine("El número es impar.");
        }
    }
}
