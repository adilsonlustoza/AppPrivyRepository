using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppPrivy.Domain.Entities.DoacaoMais
{
    [Table("Usuario", Schema = "DoacaoMais")]
    public partial class Usuario: Entity
    {
        [Key]
        public int UsuarioId { get; set; }

        [StringLength(150)]
        public string Login { get; set; }

        [StringLength(350)]
        public string Email { get; set; }
        
        public virtual ICollection<Dispositivo> Dispositivo { get; set; }

    }
}
