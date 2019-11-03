
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AppPrivy.Domain.Entities.ObjectValue;

namespace AppPrivy.Domain.Entities.DoacaoMais
{
    [Table("Bazar", Schema ="DoacaoMais")]
    public class Bazar : Entity
    {
         [Key]
        public int BazarId { get; set; }

        [StringLength(150)]
        public string Nome { get; set; }

        [StringLength(250)]
        public string Informacao { get; set; }

        public Endereco Endereco { get; set; }

        [StringLength(300)]
        public string Email { get; set; }

        [StringLength(14)]
        public string Telefone { get; set; }

        [StringLength(300)]
        public string OutrosContatos { get; set; }

        [StringLength(500)]
        public string UrlImagem { get; set; }
    

        /**********************************************Relation Area**************************************************/

        [ForeignKey("Caccc")]
        public int CacccId { get; set; }

        public virtual Caccc Caccc { get; set; }
        
    }
}