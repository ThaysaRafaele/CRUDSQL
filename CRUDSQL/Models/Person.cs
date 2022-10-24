using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CRUDSQL.Models
{
    [Table("Person")]
    public class Person
    {
        [Column("Id")]
        [Display(Name = "Código")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome Completo")]
        public string Nome { get; set; }

        [Column("CPF")]
        [Display(Name = "CPF")]
        public string CPF { get; set; }

        [Column("Nascimento")]
        [Display(Name = "Data de Nascimento")]
        public DateTime Nascimento { get; set; }

        [Column("Renda")]
        [Display(Name = "Valor da Renda")]
        public Decimal Renda { get; set; }
    }
}
