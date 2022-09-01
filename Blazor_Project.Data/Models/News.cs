using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazor_Project.Data.Models
{
    public class News : BaseEntity
    {
        [Display(Name = "عنوان خبر")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = " نمی تواند بیش از {1} کاراکتر باشد {0}")]
        public string Title { get; set; }

        [Display(Name = "توضیحات کوتاه")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        [MaxLength(150, ErrorMessage = " نمی تواند بیش از {1} کاراکتر باشد {0}")]
        public string ShortDescription { get; set; }

        [Display(Name = "توضیحات")]
        [Required(ErrorMessage = "لطفا {0} را وارد کنید")]
        public string Description { get; set; }

        [Display(Name = "نام تصویر")]
        [MaxLength(250, ErrorMessage = " نمی تواند بیش از {1} کاراکتر باشد {0}")]
        public string ImageName { get; set; }

        [Display(Name = "تعداد بازدید")]
        public int Visits { get; set; }

        [ForeignKey("NewsCategory")]
        public int NewsCategoryId { get; set; }

        public NewsCategory NewsCategory { get; set; }
    }
}
