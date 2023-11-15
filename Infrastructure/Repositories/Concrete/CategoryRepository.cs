using CRUD_Mvc.Entities.Concrete;
using CRUD_Mvc.Infrastructure.Context;
using CRUD_Mvc.Infrastructure.Repositories.Interface;
using System.Linq.Expressions;

namespace CRUD_Mvc.Infrastructure.Repositories.Concrete
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly AppDbContext _context;

        public CategoryRepository(AppDbContext context)
        {
            _context = context;
        }
        public void Create(Category entity)
        {
            _context.Categories.Add(entity);
            _context.SaveChanges();
        }
        public void Update(Category entity)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == entity.Id);  
            category.Name = entity.Name;
            category.Description = entity.Description;
            category.UpdatedDate = DateTime.Now;
            category.Status = Entities.Abstract.Status.Modified;
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public void Delete(Category entity)
        {
            var category = _context.Categories.FirstOrDefault(x => x.Id == entity.Id);
            category.DeletedDate = DateTime.Now;
            category.Status = Entities.Abstract.Status.Passive;
            _context.Categories.Update(category);
            _context.SaveChanges();
        }

        public Category GetByDefault(Expression<Func<Category, bool>> expression)
        {
            var category = _context.Categories.FirstOrDefault(expression);
            return category;
        }

        public List<Category> GetByDefaults(Expression<Func<Category, bool>> expression)
        {
            var categories = _context.Categories.Where(expression).ToList();
            return categories;
        }

    }
}
