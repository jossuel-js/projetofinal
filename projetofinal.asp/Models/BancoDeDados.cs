using Microsoft.EntityFrameworkCore;

namespace projetofinal.asp.Models
{
    public class BancoDeDados :DbContext
    {
        public DbSet<Consumidor> Consumidors { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Boleto> Boletos { get; set; }
        public DbSet<CartãoCredito> CartãoCreditos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Server=(localdb)\mssqllocaldb;Database=projetofinal");
        }
    }
}
