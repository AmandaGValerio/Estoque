using System;
using System.Collections.Generic;
using System.Linq;

namespace Estoque
{
    public class Menu
    {
        public static int MenuPrincipal ()
        {
            Console.WriteLine("1- Registrar Peça no estoque");
            Console.WriteLine("2- Registrar um serviço no catálogo");
            Console.WriteLine("3- Registrar um pedido");
            Console.WriteLine("4- Cadastrar Cliente");
            Console.WriteLine("5- Mostrar todos os pedidos");
            Console.WriteLine("6- Vender Peca");
            Console.WriteLine("7- ");
            Console.WriteLine("0- Sair da Aplicação");
            Console.WriteLine("Digite o número da opção escolhida: ");

            return int.Parse(Console.ReadLine());
        }

        public static void AdicionarAoBanco (Object obj)
        {
             using (var db = new EstoqueContext())
            {
                db.Add(obj);
                db.SaveChanges();
            }
        }
    }
}