using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestTicket.Models
{
    [Table("Adresses")]
    public class Adresses
    {
        [Column("adressId")]
        [Display(Name = "AdressId")]
        [Key]
        public int AdressId { get; set; }

        [Column("userId")]
        [Display(Name = "UserId")]
        [ForeignKey("UserId")]
        public int UserId { get; set; }

        [Column("postCode")]
        [Display(Name = "Cep")]
        public string PostCode { get; set; }

        [Column("country")]
        [Display(Name = "País")]
        public string Country { get; set; }

        [Column("state")]
        [Display(Name = "Estado")]
        public string State { get; set; }

        [Column("city")]
        [Display(Name = "Cidade")]
        public string City { get; set; }

        [Column("neighborhood")]
        [Display(Name = "Bairro")]
        public string Neighborhood { get; set; }

        [Column("street")]
        [Display(Name = "Rua")]
        public string Street { get; set; }

        [Column("number")]
        [Display(Name = "Numero")]
        public string Number { get; set; }

        [Column("complement")]
        [Display(Name = "Complemento")]
        public string Complement { get; set; }

        [Column("category")]
        [Display(Name = "Categoria")]
        public string Category { get; set; }

        public virtual Users user { get; set; }
    }
}
