using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Estoque
{
    public class Cliente
    {
        public Cliente (string nome, string endereco, string telefone, string cpf)
        {
            this.Id = Guid.NewGuid();
            this.Nome = nome;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.CPF = cpf;
        }

        public Cliente ()
        {
            this.Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }

        public static void Read()
        {
            using (var db = new EstoqueContext())
            {
                List<Cliente> clientes = db.Clientes.ToList();
                foreach (Cliente c in clientes)
                {
                    Console.WriteLine("{0}    {1}    {2}    {3}    {4}", c.Id, c.Nome, c.Endereco, c.Telefone, c.CPF);
                }
            }
            return;
        }

    }
}