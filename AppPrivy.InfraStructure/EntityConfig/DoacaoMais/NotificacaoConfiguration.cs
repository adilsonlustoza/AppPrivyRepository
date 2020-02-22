using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.Data.EntityConfig.DoacaoMais
{
    public class NotificacaoConfiguration: IEntityTypeConfiguration<Notificacao>
    {      

        public void Configure(EntityTypeBuilder<Notificacao> builder)
        {
            builder.ToTable("Notificacao", "DoacaoMais");          

            builder.HasKey(x => x.NotificacaoId);

            builder.Property(x => x.NotificacaoId)
           .HasColumnName("NotificacaoId")
           .IsRequired()
           .ValueGeneratedOnAdd();       


        }
    }
}
