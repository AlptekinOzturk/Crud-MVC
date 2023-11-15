using CRUD_Mvc.Entities.Concrete;
using System.Linq.Expressions;

namespace CRUD_Mvc.Infrastructure.Repositories.Interface
{
    public interface ICategoryRepository
    {
        void Create(Category entity);
        void Update(Category entity);
        void Delete(Category entity);

        //Read Methodlar
        //Örnek sorgu => GetByDefault(x => x.Id ==6)
        Category GetByDefault(Expression<Func<Category, bool>> expression);
        List<Category> GetByDefaults(Expression<Func<Category, bool>> expression);  

    }
}
