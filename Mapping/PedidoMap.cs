using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProvaApi.Model;

namespace ProvaApi.Mapping{
    public class PedidoMap: IEntityTypeConfiguration<Pedido>{
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedido", "prova");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
            .HasColumnName("id");
            
            builder.Property(x => x.NomeProduto)
            .HasColumnName("nome_produto");
            
            builder.Property(x => x.Celular)
            .HasColumnName("celular");
        }
    }
}