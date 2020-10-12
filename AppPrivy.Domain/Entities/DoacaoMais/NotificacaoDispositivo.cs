namespace AppPrivy.Domain.Entities.DoacaoMais
{
    public class NotificacaoDispositivo
    {

        public int DispositivoId { get; set; }

        public Dispositivo Dispositivo { get; set; }

        public int NotificacaoId { get; set; }

        public Notificacao Notificacao { get; set; }
    }
}
