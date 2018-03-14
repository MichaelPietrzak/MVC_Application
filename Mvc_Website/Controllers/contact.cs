using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.Data.Entity;

namespace Mvc_Website.Models
{
    public class contact
    {
        [Display(Name = "Imię i Nazwisko")]
        [Required(ErrorMessage = "Wpisz swoje imię i nazwisko")]
        public string Name { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Wpisz adres e-mail")]
        [RegularExpression(@"\s*[\w|.|-]*@\w*\.[\w|.]*\s*", ErrorMessage = "Wprowadź poprawny email!")]
        public string Email { get; set; }

        [Display(Name = "Opis Food Trucka")]
        [Required(ErrorMessage = "Opisz Food Trucka")]
        public string Description { get; set; }
    }
}