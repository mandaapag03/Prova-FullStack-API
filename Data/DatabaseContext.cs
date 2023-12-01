using Microsoft.EntityFrameworkCore;
using ProvaApi.Mapping;
using ProvaApi.Model;

namespace ProvaApi.Data{
    public class DatabaseContext : DbContext {
        
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var config = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.Development.json").Build();
            options.UseNpgsql(config.GetConnectionString("PostgreSQL"));
            options.LogTo(Console.WriteLine);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new PedidoMap());
        }
    }
}