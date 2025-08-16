using System;

namespace Ejercicio_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese el dia de la semana
            Console.Write("Por favor, ingresa el dia de la semana: ");
            string dia = Console.ReadLine();

            if (dia == "lunes" || dia == "martes")
            {
                Console.WriteLine("Es inicio de semana");
            } else if(dia == "miercoles" || dia == "jueves" || dia == "viernes")
            {
                Console.WriteLine("Es mitad de semana");
            } else if(dia == "sabado" || dia == "domingo")
            {
                Console.WriteLine("Es fin de semana");
            } else
            {
                Console.WriteLine("Día no válido. Por favor, ingresa un día de la semana correcto.");

            }
        }
    }
}
