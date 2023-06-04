using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class HomeModels
    {
        //[HiddenInput(DisplayValue = false)]
        [Display(Name = "Имя")]
        [UIHint("MultilineText")]
        [Required(ErrorMessage ="Введите Имя")] 
        public string? FirstName {get;set;}

        [Display(Name = " Фамилия")]
        [UIHint("MultilineText")]
        [Required(ErrorMessage = "Введите Фамилию")]
        public string? LastName { get;set;}
        
        [Display(Name = "Дата Рождения")]
        [DataType(DataType.Date)]
        [Required (ErrorMessage = "Введите Дату Рождения")]
        public DateTime BirthDate { get;set;}

        [Display(Name = "Телефон")]
        [StringLength(11, MinimumLength = 10, ErrorMessage = "Длина строки должна быть от 10, до 11 символов")]
        [Required(ErrorMessage = "Введите Телефон")]
        public string? Phone { get;set;}

        [Display(Name = "Год")]
        [Range(1700, 2000, ErrorMessage = "Недопустимый год")]
        public int Year { get; set; }

        public bool? Will { get; set; }

    }
}
