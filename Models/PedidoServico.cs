using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque
{
    public class PedidoServico
    {
        [ForeignKey("Pedido")]
        public Guid IdPedido { get; set; }
        [ForeignKey("Servico")]
        public Guid IdServico { get; set; }

        public PedidoServico()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasNoKey();
        }
        
    }
}