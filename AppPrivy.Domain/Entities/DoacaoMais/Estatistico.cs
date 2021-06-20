using AppPrivy.Domain.Entities.ObjectValue;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.DoacaoMais
{
    [Table("Estatistico", Schema = "DoacaoMais")]
	public class Estatistico: Entity
	{
		
		public int EstatisticoId { get; set; }
		public decimal Valor { get; set; }
		public string Nome { get; set; }		
		public string Descricao { get; set; }
		public string Fonte { get; set; }
		public TipoEstatisco Tipo { get; set; }


	}
}
