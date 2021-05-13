using System;
using System.Collections.Generic;
using System.Globalization;
using System.Data.Entity;
using System.Linq;

namespace Estoque
{
    public class Pedido
    {
        public Guid Id { get; set; }
        public Cliente Cliente { get; set; }
        public List<Peca> Pecas { get; set; }
        public DateTime DataPedido { get; set; }
        public bool ConfirmaPagamento { get; set; }
        public List<Servico> Servicos { get; set; }

        public Pedido()
        {
            Id = Guid.NewGuid();
        }

        public Pedido(Cliente cliente, List<Peca> pecas, bool confirmaPagamento)
        {
            Id = Guid.NewGuid();
            Cliente = cliente;
            Pecas.AddRange(pecas);
            DataPedido = DateTime.Now;
            ConfirmaPagamento = confirmaPagamento;
        }

        public Pedido(Cliente cliente, List<Servico> servicos, bool confirmaPagamento)
        {
            Id = Guid.NewGuid();
            Cliente = cliente;
            Servicos.AddRange(servicos);
            DataPedido = DateTime.Now;
            ConfirmaPagamento = confirmaPagamento;
        }

        public Pedido(Cliente cliente, List<Peca> pecas, List<Servico> servicos, bool confirmaPagamento)
        {
            Id = Guid.NewGuid();
            Cliente = cliente;
            Pecas.AddRange(pecas);
            Servicos.AddRange(servicos);
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
                    Console.WriteLine("{0} {1}", p.Id, p.DataPedido);
                }
            }
            return;
        }
    }
}