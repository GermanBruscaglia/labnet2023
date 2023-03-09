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

            List<Omnibus> listaOmnibus = new List<Omnibus>();

            for (var i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Cantidad de pasajeros Omnibus{i}");
                listaOmnibus.Add(new Omnibus(Int32.Parse(Console.ReadLine()), $"Omnibus{i}"));
             }

            List<Taxi> listaTaxi = new List<Taxi>();

            for (var i = 1; i <= 5; i++)
            {
                Console.WriteLine($"Cantidad de pasajeros Taxi{i}");
                listaTaxi.Add(new Taxi(Int32.Parse(Console.ReadLine()), $"Taxi{i}"));
            }


            Console.Clear();
            Console.WriteLine("Lista de pasajeros de Omnibus");
            foreach(var item in listaOmnibus)
            {
                    Console.WriteLine(item.Listarvehivulos());
            }

            Console.WriteLine("Lista de pasajeros de Taxi");
            foreach (var item in listaTaxi)
            {
                Console.WriteLine(item.Listarvehivulos());
            }

            Console.Read();
        }
    }
}

