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

            /*Practica final*/
            //EmployeesLogic employeesLogic = new EmployeesLogic();
            //Console.WriteLine("Lista de Empleados:");
            //foreach (var employees in employeesLogic.GetAll())
            //{
            //    Console.WriteLine($"- {employees.FirstName} {employees.LastName} - Numero Id: {employees.EmployeeID}");
            //}

            //Console.WriteLine(""); 

            //Console.WriteLine("Lista de Categorias:");
            //CategoriesLogic categoriesLogic = new CategoriesLogic();

            //foreach (var categories in categoriesLogic.GetAll())
            //{
            //    Console.WriteLine($"- Nombre: {categories.CategoryName} - Descripcion: {categories.Description} - Numero Id: {categories.CategoryID}");
            //}

            //Console.WriteLine("");

            //Console.WriteLine("Operaciones sobre lista de Empleados");
            //    Console.WriteLine("Eliga la operacion que desea realizar:");
            //    Console.WriteLine("1 - Agregar:");
            //    Console.WriteLine("2 - Borrar:");
            //    Console.WriteLine("3 - Modificar:");
            //int operacion = Int32.Parse(Console.ReadLine());

            //switch (operacion)
            //{
            //    case 1:
            //        Console.WriteLine("Ingrese Nombre");
            //        string addNombre = Console.ReadLine();
            //        Console.WriteLine("Ingrese Apellido");
            //        string addApellido = Console.ReadLine();
            //        employeesLogic.Add(new Employees
            //        {
            //            FirstName = addNombre,
            //            LastName = addApellido
            //        });
            //        break;
            //    case 2:
            //        Console.WriteLine("Ingrese ID del Empleado que desea eliminar");
            //        int deleteId = Int32.Parse(Console.ReadLine());
            //        employeesLogic.Delete(deleteId);
            //        break;
            //    case 3:
            //        Console.WriteLine("Ingrese Nombre nuevo");
            //        string updateNombre = Console.ReadLine();
            //        Console.WriteLine("Ingrese Apellido nuevo");
            //        string updateApellido = Console.ReadLine();
            //        Console.WriteLine("Ingrese ID del empleado que desea modificar");
            //        int updateID = Int32.Parse(Console.ReadLine());
            //        employeesLogic.Update
            //            (new Employees
            //        {
            //            FirstName = updateNombre,
            //            LastName = updateApellido,
            //            EmployeeID = updateID
            //        });
            //        break;
            //}

            //if(operacion < 1 || operacion > 3)
            //{
            //    Console.WriteLine("Por favor ingrese un numero de las opciones");
            //}

            /*Ejercicio 1*/
            CustomersLogic customersLogic = new CustomersLogic();

            var allCustomers = customersLogic.GetAll();
            //var objetoCustomers = allCustomers.FirstOrDefault();
            //Console.WriteLine(objetoCustomers);

            /*Ejercicio 2*/
            ProductsLogic productsLogic = new ProductsLogic();
            var allProducts = productsLogic.GetAll();
            //var productosSinStock = allProducts.Where(p => p.UnitsInStock == 0).ToList();
            //foreach (var item in productosSinStock)
            //{
            //    Console.WriteLine("Productos con stock cero:");
            //    Console.WriteLine($"- {item.ProductName}");
            //}

            /*Ejercicio 3*/
            //var masTresPorUnidad = allProducts.Where(e => e.UnitsInStock > 0)
            //                                  .Where(e => e.UnitPrice > 3)
            //                                  .ToList();
            //foreach (var item in masTresPorUnidad)
            //{
                
            //    Console.WriteLine($"- {item.UnitsInStock} - {item.UnitPrice}");
            //}

            /*Ejercicio 4*/

            //var regioncustomersWA = from customersRegion in allCustomers 
            //                        where customersRegion.Region == "WA" 
            //                        select customersRegion;
            //foreach (var item in regioncustomersWA)
            //{

            //    Console.WriteLine($"- {item.CompanyName} - {item.Region}");
            //}

            /*Ejercicio 5*/
            var primerElementoID = allProducts.Where(p => p.ProductID == 789).FirstOrDefault();

            Console.WriteLine(primerElementoID);

            /*Ejercicio 6*/

            foreach(var nombrecustomers in allCustomers)
            {
                Console.WriteLine(nombrecustomers.ContactName.ToUpper());
                Console.WriteLine(nombrecustomers.ContactName.ToLower());

            }

            Console.ReadLine();

            
        }
        
    }
}
