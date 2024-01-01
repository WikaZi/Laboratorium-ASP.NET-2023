using Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Laboratorium_3___App.Models
{
    public enum UsageStatus
    {
        [Display(Name = "Nowy")]
        New,
        [Display(Name = "Używany")]
        Used,
        [Display(Name = "Ulepszony")]
        Upgraded,
        [Display(Name = "Uszkodzony")]
        Damaged,
    }
    public class Computer
    {
        [HiddenInput]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podać imię!")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Display(Name = "Procesor")]
        public string Processor { get; set; }
        [Display(Name = "Pamięć")]
        public string Memory { get; set; }
        [Display(Name = "Karta graficzna")]
        public string GraphicsCard { get; set; }
        [Display(Name = "Producent")]
        public string Producer { get; set; }

        [Display(Name = "Data produkcji")]
        [DataType(DataType.Date)]
        public DateTime DateOfProduction { get; set; }
        [Display(Name = "Status")]
        public UsageStatus Status { get; set; }
        public string? SoftwareName { get; set; }
        public virtual Software Software { get; set; }
    }
}
