using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestTicket.Models
{
    [Table("Users")]
    public class Users
    {
        [Column("userId")]
        [Display(Name = "Id")]
        [Key]
        public int userId { get; set; }

        [Column("name")]
        [Display(Name = "Nome")]
        [Required]
        public string Name { get; set; }

        [Column("email")]
        [Display(Name = "Email")]
        [Required]
        public string Email { get; set; }

        [Column("dateOfBrith")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [Required]
        public DateTime? DateOfBrith { get; set; }

        [Column("phone")]
        [Display(Name = "Telefone")]
        [Required]
        public string Phone { get; set; }

        [Display(Name = "Endereços")]
        public virtual ICollection<Adresses> Adresses { get; set; }
    }
}
