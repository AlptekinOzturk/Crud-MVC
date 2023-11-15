using CRUD_Mvc.Entities.Concrete;
using CRUD_Mvc.Infrastructure.EntitytypeConfiguration.Abstract;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CRUD_Mvc.Infrastructure.EntitytypeConfiguration.Concrete
{
    public class CategoryMap : BaseMap<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(x=>x.Name).HasMaxLength(30).IsRequired(true);
            builder.Property(x => x.Description).HasMaxLength(600).IsRequired(true);

                base.Configure(builder);
        }
    }
}
