using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestTicket.Models
{
    [Table("LogInformation")]
    public class LogInformation
    {
        [Column("logId")]
        [Display(Name = "LogId")]
        [Key]
        public int LogId { get; set; }

        [Column("userEmail")]
        [Display(Name = "UserEmail")]
        public string UserEmail { get; set; }

        [Column("informations")]
        [Display(Name = "Informações")]
        public string Informations { get; set; }
    }
}
