using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.DoacaoMais
{
    [Table("ContaBancaria", Schema = "DoacaoMais")]
    public partial class ContaBancaria : Entity
    {
        [Key]
        public int ContaBancariaId { get; set; }

        public string NumeroBanco { get; set; }

        public string NomeBanco { get; set; }

        public string Agencia { get; set; }

        public string Conta { get; set; }

        public string Beneficiario { get; set; }

        public string UrlImagem { get; set; }

        [ForeignKey("Caccc")]
        public int CacccId { get; set; }

        public virtual Caccc Caccc { get; set; }

    }
}