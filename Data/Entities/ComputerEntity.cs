using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Data.Entities
{
    [Table("Computers")]
    public class ComputerEntity
    {
      
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
      
    }
}
