using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    public class Ejercicio1
    {
        public static string  Division()
        {
            Console.WriteLine("Ingrese numero a dividir:");
            int num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese divisor:");
            int num2 = Int32.Parse(Console.ReadLine());
            try
            {
                float division = num1 / num2;
                return $"El resultado de la division es: {division}";
            }
            catch (DivideByZeroException ex)
            {
                return $"Error: {ex.Message}";
            }
            finally
            {
                Console.WriteLine("La operación ha finalizado");
            }
        }
    }
}


    
