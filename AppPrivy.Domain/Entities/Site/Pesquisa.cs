using AppPrivy.Domain.Entities;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain
{

    [Table("Pesquisa", Schema = "Site")]
    public partial class Pesquisa : Entity
    {

        [Key]
        public int PesquisaId { get; set; }

        [StringLength(150)]
        [DataType(DataType.Text)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Titulo é requerido!")]
        public string Titulo { get; set; }

        [StringLength(1500)]
        [DataType(DataType.MultilineText)]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Descrição é requerida!")]
        public string Descricao { get; set; }

        [StringLength(500)]
        [DataType(DataType.Url, ErrorMessage = "Url com formato incorreto")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Url é requerida!")]
        public string Url { get; set; }

        [DataType(DataType.Upload)]
        public byte[] Image { get; set; }

    }


}
