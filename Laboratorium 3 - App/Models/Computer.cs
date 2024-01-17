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

        [Required(ErrorMessage = "Proszę podać nazwę!")]
        [Display(Name = "Nazwa")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Proszę podać wersję procesora!")]
        [Display(Name = "Procesor")]
        public string Processor { get; set; }
        [Required(ErrorMessage = "Proszę podać odpowiednią wartość!")]
        [Display(Name = "Pamięć")]
        public string Memory { get; set; }
        [Required(ErrorMessage = "Proszę podać pełną nazwę!")]
        [Display(Name = "Karta graficzna")]
        public string GraphicsCard { get; set; }
        [Required(ErrorMessage = "Proszę podać nazwę producenta!")]
        [Display(Name = "Producent")]
        public string Producer { get; set; }

        [Display(Name = "Data produkcji")]
        [DataType(DataType.Date)]
        public DateTime DateOfProduction { get; set; }
        [Display(Name = "Status")]
        public UsageStatus Status { get; set; }
       
    }
}
