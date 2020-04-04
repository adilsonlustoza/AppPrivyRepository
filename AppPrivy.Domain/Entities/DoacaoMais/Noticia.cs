using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppPrivy.Domain.Entities.DoacaoMais
{
    [Table("Noticia", Schema = "DoacaoMais")]
    public class Noticia : Entity
    {

        [Key]
        public int NoticiaId { get; set; }

        [StringLength(300)]
        public string Titulo { get; set; }

        [StringLength(300)]
        public string SubTitulo { get; set; }

        [StringLength(8000)]
        public string Conteudo { get; set; }

        [StringLength(500)]
        public string UrlImagem { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DataType(DataType.Date)]
        public DateTime? DataPublicacao { get; set; }
        /**********************************************Relation Area**************************************************/
        [ForeignKey("Caccc")]
        public int? CacccId { get; set; }

        public virtual Caccc Caccc { get; set; }



    }


}