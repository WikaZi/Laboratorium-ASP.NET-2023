using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    [Table("Licences")]
    public class SoftwareLicenseEntity
    {
        [Key]
        public int Id { get; set; }
        public string LicenseKey { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string LicenseType { get; set; }

        public int ComputerId { get; set; }
        public int SoftwareId { get; set; }

        public virtual ComputerEntity Computer { get; set; }
        public virtual SoftwareEntity Software { get; set; }
    }
}
