using Lab.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab.EF.Logic
{
    public class CategoriesLogic : BaseLogic, IABMLogic<Categories>
    {
        public void Add(Categories newCategories)
        {
            context.Categories.Add(newCategories);
            context.SaveChanges();
        }
        public void Delete(int id)
        {
            var categoriaAEliminiar = context.Categories.Find(id);

            context.Categories.Remove(categoriaAEliminiar);

            context.SaveChanges();
        }

        public List<Categories> GetAll()
        {
            return context.Categories.ToList();
        }

        public void Update(Categories categories)
        {
            var categoriesUpdate = context.Categories.Find(categories.CategoryID);

            categoriesUpdate.CategoryName = categoriesUpdate.CategoryName;

            context.SaveChanges(); ;
        }
    }
}
