using AppPrivy.Domain.Entities.ObjectValue;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.DoacaoMais
{

    [Table("Campanha", Schema = "DoacaoMais")]
    public partial class Campanha : Entity
    {
        public Campanha()
        {
            Notificacoes = new HashSet<Notificacao>();
        }

        [Key]
        public int CampanhaId { get; set; }

        [StringLength(150)]
        public string Nome { get; set; }

        [StringLength(3500)]
        public string Descricao { get; set; }

        [StringLength(1000)]
        public string LinkWeb { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DataType(DataType.Date)]
        public DateTime? DataInicial { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DataType(DataType.Date)]
        public DateTime? DataFinal { get; set; }

        [StringLength(300)]
        public string UrlImagem { get; set; }

        public bool Ativa { get; set; }

        public virtual TipoBoletim TipoCampanha { get; set; }

        /**********************************************Relation Area**************************************************/

        [ForeignKey("Caccc")]
        public int CacccId { get; set; }

        public virtual Caccc Caccc { get; set; }

        public virtual ICollection<Notificacao> Notificacoes { get; set; }


    }
}