
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppPrivy.Domain.Entities.DoacaoMais
{
   
    [Table("Disposito", Schema = "DoacaoMais")]
    public partial class Dispositivo: Entity
    {

        public Dispositivo()
        {
            NotificacaoDispositivos = new HashSet<NotificacaoDispositivo>();
        }

        [Key]
        public int DispositivoId { get; set; }

        [StringLength(150)]
        public string DeviceId { get; set; }

        [StringLength(150)]
        public string Release { get; set; }

        [StringLength(150)]
        public string Incremental { get; set; }

        [StringLength(150)]
        public string VersaoSDK { get; set; }

        [StringLength(150)]
        public string FirgirPrint { get; set; }

        [StringLength(150)]
        public string Board { get; set; }

        [StringLength(150)]
        public string Brand { get; set; }

        [StringLength(150)]
        public string Device { get; set; }

        [StringLength(150)]
        public string Manufacture { get; set; }

        [StringLength(150)]
        public string Model { get; set; }

        [StringLength(150)]
        public string Host { get; set; }

        [StringLength(150)]
        public string Code { get; set; }

        [StringLength(150)]
        public string Type { get; set; }

        [StringLength(150)]
        public string Serial { get; set; }

        /**********************************************Relation Area**************************************************/

        public virtual ICollection<NotificacaoDispositivo> NotificacaoDispositivos { get; set; }





    }
}
