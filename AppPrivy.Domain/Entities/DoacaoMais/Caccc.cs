using AppPrivy.Domain.Entities.ObjectValue;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace AppPrivy.Domain.Entities.DoacaoMais
{
    [Table("Caccc", Schema = "DoacaoMais")]
    public partial class Caccc : Entity
    {
        public Caccc()
        {
            Bazares = new HashSet<Bazar>();
            Campanhas = new HashSet<Campanha>();
            Noticias = new HashSet<Noticia>();
            ContasBancarias = new HashSet<ContaBancaria>();
            Conteudos = new HashSet<Conteudo>();         
            //Tipo Complexo
            Endereco = new Endereco();


        }

        [Key]
        [JsonIgnore]
        public int CacccId { get; set; }

        [StringLength(150)]
        [Required(ErrorMessage = "{0} é requerido.")]
        public string Nome { get; set; }

        [StringLength(150)]
        public string Apelido { get; set; }

        [RegularExpression(@"^\d{2}\.\d{3}\.\d{3}/\d{4}-\d{2}$", ErrorMessage = "{0} é invalido.")]
        [Required(ErrorMessage = "{0} é requerido.")]
        public string Cnpj { get; set; }


        [EmailAddress(ErrorMessage = "{0} é invalido")]
        [Required(ErrorMessage = "{0} é requerido.")]
        public string Email { get; set; }

        [EmailAddress(ErrorMessage = "{0} é invalido")]
        public string EmailPagSeguro { get; set; }

        [EmailAddress(ErrorMessage = "{0} é invalido")]
        public string EmailPayPal { get; set; }

        [Url(ErrorMessage ="{0} é inválido")]
        public string UrlImagem { get; set; }


        [Url(ErrorMessage = "{0} é inválido")]
        public string UrlImagemPin { get; set; }


        [RegularExpression(@"^\(?\d{2}\)? \d{4,5}-\d{4}$", ErrorMessage = "{0} é invalido.")]
        [Required(ErrorMessage ="{0} é requerido.")]
        public string Telefone { get; set; }

        [RegularExpression(@"^\d{4,5}\-\d{4}$", ErrorMessage = "{0} é invalido")]
        public string Celular { get; set; }

        public bool Autorizado { get; set; }

        [StringLength(50)]
        [Required(ErrorMessage = "{0} é requerido.")]
        public string Responsavel { get; set; }


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DataType(DataType.Date)]
        public DateTime? DataFundacao { get; set; }

        public TipoDoacao TipoDoacao { get; set; }

        /**********************************************Complex Area**************************************************/

        public Endereco Endereco { get; set; }


        /**********************************************Relation Area**************************************************/

        public virtual ICollection<Conteudo> Conteudos { get; set; }

        public virtual ICollection<Bazar> Bazares { get; set; }

        public virtual ICollection<Campanha> Campanhas { get; set; }

        public virtual ICollection<Noticia> Noticias { get; set; }

        public virtual ICollection<ContaBancaria> ContasBancarias { get; set; }

 

    }
}