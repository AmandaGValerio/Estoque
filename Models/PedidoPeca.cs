using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Estoque
{
    public class PedidoPeca
    {
        [ForeignKey("Pedido")]
        public Guid IdPedido { get; set; }
        [ForeignKey("Peca")]
        public Guid IdPeca { get; set; }
        public int quantidade { get; set; }

        public PedidoPeca()
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>()
                .HasNoKey();
        }
        
    }
}