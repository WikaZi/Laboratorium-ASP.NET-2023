using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Softwares")]
    public class SoftwareEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        public string Version { get; set; }

        public ISet<ComputerEntity> Computers { get; set; }
    }
}
