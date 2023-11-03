using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace formularz.Models
{
    public class Dane
    {
        [Required(ErrorMessage = "Prosze podaj Imie")]
        [MinLength(2,ErrorMessage ="Imię musi zawierać minimum 2 znaki")]
        public string Imie {  get; set; }

        [Required(ErrorMessage = "Prosze podaj nazwisko")]
        [MinLength(2, ErrorMessage = "Nazwisko musi zawierać minimum 2 znaki")]
        public string Nazwisko { get; set; }

        [Required(ErrorMessage = "Prosze podaj Email")]
        [RegularExpression(".+\\@.+\\.[a-z]{2,3}",ErrorMessage ="Podaj poprawny email")]
        [EmailAddress]
        public string Email { get; set; }

        [Required(ErrorMessage = "Podaj haslo")]
        [MinLength(8)]
        [DataType(DataType.Password)]
        [RegularExpression(@"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$", ErrorMessage = "Hasło musi zawierać co najmniej jedną cyfrę, jedną dużą literę i jedną małą literę.")]
        public string Haslo { get; set; }

        [Required(ErrorMessage = "Potwierdź haslo")]
        [DataType(DataType.Password)]
        [Compare("Haslo", ErrorMessage = "Hasła nie pasują do siebie.")]
        public string PotwierdzenieHasla {  get; set; }

        [Required]
        [Phone]
        public string Numer {  get; set; }

        [Required]
        [Range(10,80, ErrorMessage = "Wiek musi być pomiędzy 10 a 80.")]
        public int Wiek {  get; set; }


    }
}
