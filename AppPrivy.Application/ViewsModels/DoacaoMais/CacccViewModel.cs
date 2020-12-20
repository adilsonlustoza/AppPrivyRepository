using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace AppPrivy.Application.ViewsModels.DoacaoMais
{


    public class CacccViewModel
    {
        [Key]       
        [DisplayName("CacccId")]
        [JsonIgnore]
        public int CacccId { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage ="Nome é requerido")]
        [JsonProperty(PropertyName ="Ong")]      
        public string Nome { get; set; }

        [StringLength(150)]
        public string Apelido { get; set; }

        public string Cnpj { get; set; }

        public string Email { get; set; }

        public string EmailPagSeguro { get; set; }

        public string EmailPayPal { get; set; }

        [StringLength(500)]
        public string UrlImagem { get; set; }

        [StringLength(15)]
        public string Telefone { get; set; }

        [StringLength(15)]
        public string Celular { get; set; }

        public bool Autorizado { get; set; }

        [StringLength(50)]
        public string Responsavel { get; set; }

    }
}
