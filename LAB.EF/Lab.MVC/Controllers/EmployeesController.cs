using Lab.EF.Entities;
using Lab.EF.Logic;
using Lab.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab.MVC.Controllers
{
    public class EmployeesController : Controller
    {
        EmployeesLogic logic = new EmployeesLogic();
        // GET: Employees
        public ActionResult Index()
        {
            
            List<Employees> employee = logic.GetAll();

            List<EmployeesView> employeesView = employee.Select(e => new EmployeesView
            {
                Nombre = e.FirstName,
                Id = e.EmployeeID
            }).ToList();

            return View(employeesView);
        }
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(EmployeesView employeesView)
        {
           try
            {
                Employees employeesEntity = new Employees { FirstName = employeesView.Nombre };

                logic.Add(employeesEntity);

                return RedirectToAction("Index", "Employees");
            }
            catch(Exception ex)
            {
                
               return RedirectToAction("Index","Error");
            }
        }
    }
}