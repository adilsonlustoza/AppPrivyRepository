using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.DoacaoMais
{
    [Table("Conteudo", Schema = "DoacaoMais")]
    public partial class Conteudo : Entity
    {

        [Key]
        public int ConteudoId { get; set; }

        [StringLength(150)]
        public string Titulo { get; set; }

        [StringLength(250)]
        public string Subtitulo { get; set; }

        [StringLength(4000)]
        public string Coluna { get; set; }

        [StringLength(500)]
        public string Url { get; set; }

        [ForeignKey("Caccc")]
        public int CacccId { get; set; }


        public virtual Caccc Caccc { get; set; }
    }
}