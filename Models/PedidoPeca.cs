using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq; 

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
        
    }
}