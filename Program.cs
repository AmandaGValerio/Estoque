using System;

namespace Estoque
{
    public class Program
    {
        static void Main(string[] args)
        {
            //pequeno projeto para trabalhar até a ferramenta visual estar pronta
            int operacao = Menu.MenuPrincipal();
            Servico ServicoAux = new Servico();
            switch(operacao){
                case 1:
                    Peca PecaAux = new Peca();
                    Console.Write("\n Nome: ");
                    PecaAux.Nome = Console.ReadLine();
                    Console.Write("\n Marca: ");
                    PecaAux.Marca = Console.ReadLine();
                    Console.Write("\n Quantidade: ");
                    PecaAux.Quantidade = Convert.ToInt32(Console.ReadLine());
                    Console.Write("\n Preço: R$");
                    PecaAux.Preco = Convert.ToSingle(Console.ReadLine());
                    Menu.AdicionarAoBanco(PecaAux);
                    break;
                case 2: 
                    ServicoAux = new Servico();
                    Console.Write("\n Nome: ");
                    ServicoAux.Nome = Console.ReadLine();
                    Console.Write("\n Preco: ");
                    ServicoAux.Preco = Convert.ToSingle(Console.ReadLine());
                    Menu.AdicionarAoBanco(ServicoAux);
                    break;
                case 3:
                    //buscar serviço ou produto

                    break;
                case 4:
                    Cliente ClienteAux = new Cliente();
                    Console.Write("\n Nome: ");
                    ClienteAux.Nome = Console.ReadLine();
                    Console.Write("\n Endereço: ");
                    ClienteAux.Endereco = Console.ReadLine();
                    Console.Write("\n Telefone: ");
                    ClienteAux.Telefone = Console.ReadLine();
                    Console.Write("CPF: ");
                    ClienteAux.CPF = Console.ReadLine();
                    Menu.AdicionarAoBanco(ClienteAux);
                    break;
                case 5:
                    Peca.Read();
                    break;
                case 0:
                    Console.WriteLine("Obrigada por escolher nosso sistema! :) ");
                    Environment.Exit(0);
                    break;
                default:
                    break;
            }
            ServicoAux = new Servico();
        }

        static void insertProduct()
        {
            using (var db = new EstoqueContext())
            {
                var nome = "Pen Drive";
                var qtd = 3;
                var preco = 2.3F;
                var marca = "kingston";
                Peca peca1 = new Peca(nome, marca, qtd, preco);
                db.Add(peca1);
 
                nome = "tesoura";
                qtd = 10;
                preco = 3.5F;
                marca = "3M";
                peca1 = new Peca(nome, marca, qtd, preco);
                db.Add(peca1);
 
                db.SaveChanges();
            }
            return;
        }

    }
}
