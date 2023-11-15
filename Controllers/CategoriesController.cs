using CRUD_Mvc.Entities.Concrete;
using CRUD_Mvc.Infrastructure.Repositories.Interface;
using CRUD_Mvc.Models.DTO_s;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace CRUD_Mvc.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ICategoryRepository _categoryRepo;

        public CategoriesController(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var categories = _categoryRepo.GetByDefaults(x => x.Status != Entities.Abstract.Status.Passive);
            return View(categories);
        }
        [HttpGet]
        public IActionResult CreateCategory() 
        {
            return View();  
        }


        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDTO model) 
        { 
        if (ModelState.IsValid) 
            {
                var category = new Category();
                category.Name = model.Name; 
                category.Description = model.Description;

                _categoryRepo.Create(category);
                return RedirectToAction("Index");   
            
            }
        return View(model);
        }
    }
}
