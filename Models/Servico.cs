using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;

namespace Estoque
{
    public class Servico
    {
        [Key]
        public Guid IdServico { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Servico (string nome, float preco)
        {
            IdServico = Guid.NewGuid();
            Nome = nome;
            Preco = preco; 
        }

        public Servico()
        {
            IdServico = Guid.NewGuid();
        }

        public static void Read()
        {
            using (var db = new EstoqueContext())
            {
                List<Servico> servicos = db.Servicos.ToList();
                foreach (Servico s in servicos)
                {
                    Console.WriteLine("{0}    {1}    {2}", s.IdServico, s.Nome, s.Preco);
                }
            }
            return;
        }

        public static Servico AgendarServico(Guid IdBuscado)
        {
            Servico servico;
            using (var db = new EstoqueContext())
            {
                servico = db.Servicos.Find(IdBuscado);
                db.SaveChanges();
            }
            return servico;
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