using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica2
{
    internal class Ejercicio2
    {
        public static string Division()
        {
            try
            {
                Console.WriteLine("Ingrese numero a dividir:");
                int num1 = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese divisor:");
                int num2 = Int32.Parse(Console.ReadLine());
                float division = num1 / num2;
               return $"El resultado de la division es: {division}";
            }
            catch (DivideByZeroException ex)
            {
                
                return $"Error: {ex.Message}. Solo Chuck Norris puede dividir por cero ";
            }
            catch(FormatException ex)
            {
               
                return $"Error: {ex.Message}. Seguro Ingreso una letra o no ingreso nada!";
            }
            finally
            {
                Console.WriteLine("La operacion ha finalizado");
            }
        }
    }
}
