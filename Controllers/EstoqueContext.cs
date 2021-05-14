using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MySql.Data;
using Pomelo.EntityFrameworkCore;

namespace Estoque
{
    public class EstoqueContext : DbContext
    {
        private const string connectionString = "Server=localhost;Database=estoque;User=root;";
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder.UseMySql("server=localhost;port=3306;database=estoque;uid=root;persistsecurityinfo=True;", new MySqlServerVersion(new Version(8, 0, 22)));

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Peca> Pecas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<PedidoServico> PedidosServico { get; set; }
        public DbSet<PedidoPeca> PedidosPeca { get; set; }
    }
}