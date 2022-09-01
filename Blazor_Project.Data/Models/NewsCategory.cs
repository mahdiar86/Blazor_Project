using System.ComponentModel.DataAnnotations;

namespace Blazor_Project.Data.Models
{
    public class NewsCategory : BaseEntity
    {
        [Display(Name = "عنوان دسته بندی")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(100, ErrorMessage = " نمی تواند بیش از {1} کاراکتر باشد {0}")]
        public string Title { get; set; }

        public List<News> NewsList { get; set; }
    }
}
