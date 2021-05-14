using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Estoque
{
    public class Servico
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Servico (string nome, float preco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Preco = preco; 
        }

        public Servico()
        {
            Id = Guid.NewGuid();
        }

        public static void Read()
        {
            using (var db = new EstoqueContext())
            {
                List<Servico> servicos = db.Servicos.ToList();
                foreach (Servico s in servicos)
                {
                    Console.WriteLine("{0}    {1}    {2}", s.Id, s.Nome, s.Preco);
                }
            }
            return;
        }

        public static Peca AgendarServicocd(Guid IdBuscado, int quantidadeCompra)
        {
            Peca peca;
            using (var db = new EstoqueContext())
            {
                peca = db.Pecas.Find(IdBuscado);
                if (peca.Quantidade >= quantidadeCompra){
                    peca.Quantidade = peca.Quantidade - quantidadeCompra;
                }
                else {
                    Console.WriteLine("Não foi possível realizar a compra. Total de peças: ", peca.Quantidade);
                }
                db.SaveChanges();
            }
            return peca;
        }  

        public static void deleteProduct()
        {
            using (var db = new EstoqueContext())
            {
        
                Servico servico = db.Servicos.Find(1);
                db.Servicos.Remove(servico);
                db.SaveChanges();
            }
            return;
        }    
    }
}