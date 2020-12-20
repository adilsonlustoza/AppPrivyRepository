using AppPrivy.Domain.Entities.ObjectValue;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.DoacaoMais
{
    [Table("Caccc", Schema = "DoacaoMais")]
    public partial class Caccc : Entity
    {
        public Caccc()
        {
            Bazares = new HashSet<Bazar>();
            Boletins = new HashSet<Boletim>();
            Noticias = new HashSet<Noticia>();
            ContasBancarias = new HashSet<ContaBancaria>();
            Conteudos = new HashSet<Conteudo>();
            Pacientes = new HashSet<Paciente>();
            //Tipo Complexo
            Endereco = new Endereco();


        }

        [Key]       
        public int CacccId { get; set; }

        [StringLength(150)]            
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


        [DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        [DataType(DataType.Date)]
        public DateTime? DataFundacao { get; set; }

        public TipoDoacao TipoDoacao { get; set; }

        /**********************************************Complex Area**************************************************/

        public Endereco Endereco { get; set; }


        /**********************************************Relation Area**************************************************/


        public virtual ICollection<Conteudo> Conteudos { get; set; }

        public virtual ICollection<Bazar> Bazares { get; set; }

        public virtual ICollection<Boletim> Boletins { get; set; }

        public virtual ICollection<Noticia> Noticias { get; set; }

        public virtual ICollection<ContaBancaria> ContasBancarias { get; set; }

        public virtual ICollection<Paciente> Pacientes { get; set; }

    }
}