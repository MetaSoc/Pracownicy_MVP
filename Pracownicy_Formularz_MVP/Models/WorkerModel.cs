using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Pracownicy_MVP.Models
{
    public class WorkerModel
    {
        // Fields
        private string name;
        private string surname;
        private DateTime date;
        private decimal salary;
        private string position;
        private string contract;

        // Proporties
        [DisplayName("Imię")]
        [Required(ErrorMessage = "To pole nie może być puste.")]

        public string Name
        {
            get => name;
            set => name = value;
        }

        [DisplayName("Nazwisko")]
        [Required(ErrorMessage = "To pole nie może być puste.")]
        public string Surname
        {
            get => surname;
            set => surname = value;
        }

        [DisplayName("Data urodzenia")]
        [Required(ErrorMessage = "To pole nie może być puste.")]
        public DateTime Date
        {
            get => date;
            set => date = value;
        }

        [DisplayName("Pensja")]
        [Required(ErrorMessage = "To pole nie może być puste.")]
        public decimal Salary
        {
            get => salary;
            set => salary = value;
        }

        [DisplayName("Stanowisko")]
        [Required(ErrorMessage = "To pole nie może być puste.")]
        public string Position
        {
            get => position;
            set => position = value;
        }

        [DisplayName("Rodzaj umowy")]
        [Required(ErrorMessage = "To pole nie może być puste.")]
        public string Contract
        {
            get => contract;
            set => contract = value;
        }
    }
}
