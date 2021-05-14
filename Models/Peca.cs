using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;

namespace Estoque
{
    public class Peca
    {
        [Key]
        public Guid IdPeca { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
        public int Quantidade { get; set; }
        public float Preco { get; set; }

        public Peca()
        {
            IdPeca = Guid.NewGuid();
        }

        public Peca(string nome, string marca, int quantidade, float preco)
        {
            IdPeca = Guid.NewGuid();
            Nome = nome;
            Marca = marca;
            Quantidade = quantidade;
            Preco = preco;
        }

        public bool TemNoEstoque(Guid id)
        {
            //fazer um select no bancodotnet 
            return true;
        }

        public static void Read()
        {
            using (var db = new EstoqueContext())
            {
                List<Peca> pecas = db.Pecas.ToList();
                foreach (Peca p in pecas)
                {
                    Console.WriteLine("{0}    {1}    {2}    {3}    {4}", p.IdPeca, p.Nome, p.Marca, p.Quantidade, p.Preco);
                }
            }
            return;
        }

        public static Peca Vender(Guid IdBuscado, int quantidadeCompra)
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
                Peca peca = db.Pecas.Find(1);
                db.Pecas.Remove(peca);
                db.SaveChanges();
            }
            return;
        }

    }
}