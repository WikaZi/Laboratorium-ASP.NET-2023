using System.ComponentModel.DataAnnotations;

namespace Laboratorium_2.Models
{
    public class Birth
    {
        [Required(ErrorMessage = "Pole 'Imię' jest wymagane")]
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Name) && BirthDate < DateTime.Now;
        }

        public int CalculateAge()
        {

            DateTime today = DateTime.Today;
            int age = today.Year - BirthDate.Year - (today.DayOfYear < BirthDate.DayOfYear ? 1 : 0);
            return age;
        }
        public string GreetPerson()
        {
            int age = CalculateAge();
            string greeting = $"Cześć {Name}, masz {age} lat(a)!";
            return greeting;
        }

    }

}
