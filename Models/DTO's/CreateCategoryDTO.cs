using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD_Mvc.Models.DTO_s
{
	public class CreateCategoryDTO
	{
		[Required(ErrorMessage ="Bu Alan Zorunludur!")]
		[MaxLength(30, ErrorMessage ="30 Karakter sınıırı aştınız!")]
		[DisplayName("Kategori Adı")]
		public string Name { get; set; }

		[Required(ErrorMessage ="Bu Alan zornludur")]
		[MaxLength(600, ErrorMessage ="600 karakter sınırnı aştınız")]

		public string Description { get; set; }	
	}
}
