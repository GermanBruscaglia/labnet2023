using Lab.EF.Entities;
using Lab.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LAB.EF.UI
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Ejercicio 1*****");
            /*Ejercicio 1*/
            CustomersLogic customersLogic = new CustomersLogic();

            var allCustomers = customersLogic.GetAll();
            var objetoCustomers = allCustomers.FirstOrDefault();
            Console.WriteLine(objetoCustomers);

            Console.WriteLine("*****Ejercicio 2*****");
            /*Ejercicio 2*/
            ProductsLogic productsLogic = new ProductsLogic();
            var allProducts = productsLogic.GetAll();
            var productosSinStock = allProducts.Where(p => p.UnitsInStock == 0).ToList();
            foreach (var item in productosSinStock)
            {
                Console.WriteLine("Productos con stock cero:");
                Console.WriteLine($"- {item.ProductName}");
            }

            Console.WriteLine("*****Ejercicio 3*****");
            /*Ejercicio 3*/
            var masTresPorUnidad = allProducts.Where(e => e.UnitsInStock > 0)
                                              .Where(e => e.UnitPrice > 3)
                                              .ToList();
            foreach (var item in masTresPorUnidad)
            {
                
                Console.WriteLine($"- {item.UnitsInStock} - {item.UnitPrice}");
            }

            Console.WriteLine("*****Ejercicio 4*****");
            /*Ejercicio 4*/
            var regioncustomersWA = from customersRegion in allCustomers 
                                    where customersRegion.Region == "WA" 
                                    select customersRegion;
            foreach (var item in regioncustomersWA)
            {

               Console.WriteLine($"- {item.CompanyName} - {item.Region}");
            }

            Console.WriteLine("*****Ejercicio 5****");
            /*Ejercicio 5*/
            var primerElementoID = allProducts.Where(p => p.ProductID == 789).FirstOrDefault();

            Console.WriteLine(primerElementoID);

            Console.WriteLine("*****Ejercicio 6*****");
            /*Ejercicio 6*/
            var nombresCustomers = from custoersNombre in allCustomers
                                   select custoersNombre.ContactName.ToList();
  
            Console.ReadLine();            
        }
    }
}
