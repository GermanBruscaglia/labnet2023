using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class EmployeesLogic : BaseLogic, IABMLogic<Employees>
    {
        public void Add(Employees newEmployees)
        {
            context.Employees.Add(newEmployees);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            var employeesAEliminiar = context.Employees.Find(id);
           
            context.Employees.Remove(employeesAEliminiar);
            context.SaveChanges();
        }

        public List<Employees> GetAll()
        {
            return context.Employees.ToList();
        }

        public void Update(Employees employees)
        {
            var employeesUpdate = context.Employees.Find(employees.EmployeeID);

            employeesUpdate.FirstName = employees.FirstName;
            employeesUpdate.LastName = employees.LastName;

            context.SaveChanges();
        }
    }
}
