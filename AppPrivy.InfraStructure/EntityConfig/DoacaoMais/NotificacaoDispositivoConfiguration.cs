using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{
    public class NotificacaoDispositivoConfiguration : IEntityTypeConfiguration<NotificacaoDispositivo>
    {      

        public void Configure(EntityTypeBuilder<NotificacaoDispositivo> builder)
        {
            builder.ToTable("NotificacaoDispositivo", "DoacaoMais");          

            builder.HasKey(x => new { x.NotificacaoId, x.DispositivoId });

            builder.HasOne(x => x.Dispositivo).WithMany(x => x.NotificacaoDispositivo).HasForeignKey(x => x.DispositivoId);

            builder.HasOne(x => x.Notificacao).WithMany(x => x.NotificacaoDispositivo).HasForeignKey(x => x.NotificacaoId);

                                         }
    }
}
