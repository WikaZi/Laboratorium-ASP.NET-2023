using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public class Computer
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać imię!")]
        public string Name { get; set; }

        public string Processor { get; set; }

        public string Memory { get; set; }

        public string GraphicsCard { get; set; }
        public string Producer { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfProduction { get; set; }
    }
}
