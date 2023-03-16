using Lab.EF.Data;
using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class ProductsLogic : BaseLogic, IABMLogic<Products>
    {
        public void Add(Products newRegion)
        {
            throw new NotImplementedException();
        }

        public void AddEmployees(Products newEmployees)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Products> GetAll()
        {
            return context.Products.ToList();
        }

        public void Update(Products region)
        {
            throw new NotImplementedException();
        }
    }
}
