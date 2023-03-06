using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labNetPractica1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de Pasajeros de Omnibus");

            List<string> listaOmnibus = new List<string>();

            Console.WriteLine("Ingrese cantidad de pasajeros omnibus 1");
            string omnibus1 = Console.ReadLine();
            listaOmnibus.Add($"Omnibus Número 1: {omnibus1} pasajeros");
            Console.WriteLine("Ingrese cantidad de pasajeros omnibus 2");
            string omnibus2 = Console.ReadLine();
            listaOmnibus.Add($"Omnibus Número 2: {omnibus2} pasajeros");
            Console.WriteLine("Ingrese cantidad de pasajeros omnibus 3");
            string omnibus3 = Console.ReadLine();
            listaOmnibus.Add($"Omnibus Número 3: {omnibus3} pasajeros");
            Console.WriteLine("Ingrese cantidad de pasajeros omnibus 4");
            string omnibus4 = Console.ReadLine();
            listaOmnibus.Add($"Omnibus Número 4: {omnibus4} pasajeros");
            Console.WriteLine("Ingrese cantidad de pasajeros omnibus 5");
            string omnibus5 = Console.ReadLine();
            listaOmnibus.Add($"Omnibus Número 5: {omnibus5} pasajeros");


            Console.WriteLine("Lista de Pasajeros de Taxi");

            List<string> listaTaxis = new List<string>();

            Console.WriteLine("Ingrese cantidad de pasajeros taxi 1");
            string taxi1 = Console.ReadLine();
            listaOmnibus.Add($"Taxi Número 1: {taxi1} pasajeros");
            Console.WriteLine("Ingrese cantidad de pasajeros taxi 2");
            string taxi2 = Console.ReadLine();
            listaOmnibus.Add($"Taxi Número 2: {taxi2} pasajeros");
            Console.WriteLine("Ingrese cantidad de pasajeros taxi 3");
            string taxi3 = Console.ReadLine();
            listaOmnibus.Add($"Taxi Número 3: {taxi3} taxi");
            Console.WriteLine("Ingrese cantidad de pasajeros taxi 4");
            string taxi4 = Console.ReadLine();
            listaOmnibus.Add($"Taxi Número 4: {taxi4} pasajeros");
            Console.WriteLine("Ingrese cantidad de pasajeros taxi 5");
            string taxi5 = Console.ReadLine();
            listaOmnibus.Add($"Taxi Número 5: {taxi5} pasajeros");

            Console.Clear();

            foreach (var item in listaOmnibus)
            {
                Console.WriteLine(item);
            }


            foreach (var item in listaTaxis)
            {
                Console.WriteLine(item);
            }

            Console.Read();
        }
    }
}

