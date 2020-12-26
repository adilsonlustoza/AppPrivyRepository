using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Application.ViewsModels.DoacaoMais
{


    public class CacccViewModel
    {
       
        [Key]
        [JsonProperty("Id da Ong")]
        [JsonIgnore]
        public int CacccId { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage ="Nome é requerido")]
        [JsonProperty(PropertyName ="Nome da Ong")]      
        public string Nome { get; set; }

        [StringLength(150)]
        [JsonProperty(PropertyName = "Apelido da Ong")]
        public string Apelido { get; set; }

        [JsonProperty(PropertyName = "Cnpj")]
        public string Cnpj { get; set; }


        [Required(ErrorMessage ="{0} é requerido")]
        [EmailAddress(ErrorMessage ="{0} no formato inválido.")]
        [JsonProperty(PropertyName = "E-mail")]

        public string Email { get; set; }

        [EmailAddress(ErrorMessage = "E-mail no formato inválido.")]
        [JsonProperty(PropertyName = "E-mail PagSeguro")]
        public string EmailPagSeguro { get; set; }

        [EmailAddress(ErrorMessage = "E-mail no formato inválido.")]
        [JsonProperty(PropertyName = "E-mail PayPal")]
        public string EmailPayPal { get; set; }

        [StringLength(500)]
        [JsonProperty(PropertyName = "Url da Imagem da Ong")]
        public string UrlImagem { get; set; }

        [StringLength(15)]
        public string Telefone { get; set; }

        [StringLength(15)]
        public string Celular { get; set; }

        [JsonProperty(PropertyName = "Exibir")]
        public bool Autorizado { get; set; }

        [StringLength(50)]
        [JsonProperty(PropertyName = "Responsável Ong")]
        public string Responsavel { get; set; }

    }
}
