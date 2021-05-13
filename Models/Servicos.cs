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
    }
}