using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.ObjectValue
{
    [ComplexType]
    public partial class Endereco
    {
        [StringLength(10)]
        public string Cep { get; set; }

        [StringLength(150)]
        public string Logradouro { get; set; }

        [StringLength(10)]
        public string Numero { get; set; }

        public double Longitude { get; set; }

        public double Latitude { get; set; }

        [StringLength(50)]
        public string Bairro { get; set; }

        [StringLength(100)]
        public string Cidade { get; set; }

        [StringLength(50)]
        public string Estado { get; set; }

        [StringLength(50)]
        public string Pais { get { return "Brasil"; } }

    }
}