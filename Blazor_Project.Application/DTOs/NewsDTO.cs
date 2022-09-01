using System.ComponentModel.DataAnnotations;

namespace Blazor_Project.Application.DTOs;

public class NewsDTO
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

    public int NewsCategoryId { get; set; }
}

public class EditNewsDTO
{
    public int Id { get; set; }

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

    public int NewsCategoryId { get; set; }
}