using System;
using System.Collections.Generic;
using System.Globalization;
using System.Data.Entity;
using System.Linq;

namespace Estoque
{
    public class Pedido
    {
        public Guid IdPedido { get; set; }
        public Cliente Cliente { get; set; }
        public virtual DateTime DataPedido { get; set; }
        public bool ConfirmaPagamento { get; set; }

        public Pedido()
        {
            IdPedido = Guid.NewGuid();
            DataPedido = DateTime.Now;
        }

        public Pedido(Cliente cliente, bool confirmaPagamento)
        {
            IdPedido = Guid.NewGuid();
            Cliente = cliente;
            DataPedido = DateTime.Now;
            ConfirmaPagamento = confirmaPagamento;
        }

        public static void Read()
        {
            using (var db = new EstoqueContext())
            {
                List<Pedido> pedidos = db.Pedidos.ToList();
                foreach (Pedido p in pedidos)
                {
                    Console.WriteLine("{0} {1}", p.IdPedido, p.DataPedido);
                }
            }
            return;
        }
    }
}