using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el primer número:");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número:");
        int num2 = Convert.ToInt32(Console.ReadLine());

        int suma = num1 + num2;
        Console.WriteLine("La suma de {0} y {1} es {2}", num1, num2, suma);
    }
}
