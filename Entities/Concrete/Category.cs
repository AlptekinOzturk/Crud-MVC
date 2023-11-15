using CRUD_Mvc.Entities.Abstract;

namespace CRUD_Mvc.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }    
        public string Description { get; set; } 
    }
}
