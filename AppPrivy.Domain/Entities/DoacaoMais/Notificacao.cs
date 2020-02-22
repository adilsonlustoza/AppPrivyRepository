using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppPrivy.Domain.Entities.DoacaoMais
{


    [Table("Notificacao", Schema = "DoacaoMais")]
    public partial class Notificacao : Entity
    {
        public Notificacao()
        {
            NotificacaoDispositivos = new HashSet<NotificacaoDispositivo>();
        }

        [Key]
        public int NotificacaoId { get; set; }

        [StringLength(150)]
        public string Titulo { get; set; }

        [StringLength(500)]
        public string Descricao { get; set; }
        
        [StringLength(3500)]
        public string Conteudo { get; set; }

        [DataType(DataType.Date)]
        public DateTime? DataInicial { get; set; }
    
        [DataType(DataType.Date)]
        public DateTime? DataFinal { get; set; }   

        public bool Ativa { get; set;}

        /*****************************************Relation areas**************************************************/

        public virtual ICollection<NotificacaoDispositivo> NotificacaoDispositivos { get; set; }

    }
}
