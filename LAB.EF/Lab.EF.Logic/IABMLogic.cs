using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    internal interface IABMLogic<T>
    {
        List<T> GetAll();
        void Add(T add);
        void Delete(int id);
        void Update(T update);
    }
}
