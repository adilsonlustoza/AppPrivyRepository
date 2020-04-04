using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.DoacaoMais
{

    [Table("Paciente", Schema = "DoacaoMais")]
    public partial class Paciente : Entity
    {
        public Paciente()
        {

        }

        [Key]
        public int PacienteId { get; set; }

        [StringLength(150)]
        public string Nome { get; set; }

        public int? Idade { get; set; }

        [StringLength(45)]
        public string Enfermidade { get; set; }

        [StringLength(300)]
        public string UrlImagem { get; set; }

        /**********************************************Relation Area**************************************************/

        [ForeignKey("Caccc")]
        public int? CacccId { get; set; }

        public virtual Caccc Caccc { get; set; }
    }
}