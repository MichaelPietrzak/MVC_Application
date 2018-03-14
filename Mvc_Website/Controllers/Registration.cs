using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Mvc_Website.Models
{
    public class registration
    {
        [Display(Name = "Nazwa Food Trucka")]
        [Required(ErrorMessage = "Wpisz nazwę Food Trucka")]
        public string NameOfTruck { get; set; }

        [Display(Name = "Rok Założenia")]
        [Required(ErrorMessage = "Wybierz date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string YearSince { get; set; }

        [Display(Name = "Miasto")]
        [Required(ErrorMessage = "Wybierz miasto")]
        public string City { get; set; }

        [Display(Name = "Opis Food Trucka")]
        [Required(ErrorMessage = "Opisz Food Trucka")]
        public string Description { get; set; }

        [Display(Name = "Kasa Fiskalna")]
        public string kasa { get; set; }

        [Display(Name = "Imię i Nazwisko")]
        [Required(ErrorMessage = "Wpisz swoje imię i nazwisko")]
        public string Name { get; set; }

        [Display(Name = "Numer Telefonu")]
        [Required(ErrorMessage = "Wpisz numer Telefonu")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\s*(\+\d{2})?[\s]?(\d{3}[\s-]?){2}(\d{3})\s*$", ErrorMessage = "Wprowadz poprawny numer telefonu!")]
        public string PhoneNumber { get; set; }

        [Display(Name = "Adres e-mail")]
        [Required(ErrorMessage = "Wpisz adres e-mail")]
        [RegularExpression(@"\s*[\w|.|-]*@\w*\.[\w|.]*\s*", ErrorMessage = "Wprowadź poprawny adres email!")]
        public string Email { get; set; }

        [Display(Name = "facebook fanpage")]
        [Required(ErrorMessage = "Wpisz adres fanpage")]
        [RegularExpression(@"\s*(?:https?:\/\/)?(?:www\.)?(?:pl-pl\.)?(facebook)\.(com)\/(?:(?:\w\.)*)?(?:[\w\-\.]*\/)*\s*", ErrorMessage = "Wprowadź poprawny adres!")]
        public string FacebookFunpage { get; set; }

        [Display(Name = "Strona internetowa")]
        [Required(ErrorMessage = "Wpisz adres internetowy")]
        [RegularExpression(@"\s*(?:https?:\/\/)?(?:www\.)([\w\d-_]+)\.([\w\d-_\.]+)\/?\??([^#\n\r]*)?#?([^\n\r]*)?\s*", ErrorMessage = "Wprowadź poprawny adres!")]
        public string Website { get; set; }

    }
}

