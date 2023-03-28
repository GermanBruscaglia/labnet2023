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
    public class CategoriesController : Controller
    {
        CategoriesLogic logic = new CategoriesLogic();

        // GET: Categories
        public ActionResult Index()
        {
            List<Categories> categorie = logic.GetAll();

            List<CategoriesView> categoriesView = categorie.Select(c => new CategoriesView
            {
                Nombre = c.CategoryName,
                Id = c.CategoryID
            }).ToList();

            return View(categoriesView);
        }
        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoriesView categoriesView)
        {
            try
            {
                Categories categoriesEntity = new Categories { CategoryName = categoriesView.Nombre };
                logic.Add(categoriesEntity);
                return RedirectToAction("Index", "Categories");
            }

            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index", "Categories");
        }
    }
}