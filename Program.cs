using System;
using System.Collections.Generic;

namespace Estoque
{
    public class Program
    {
        static void Main(string[] args)
        {
            //pequeno projeto para trabalhar até a ferramenta visual estar pronta
            int operacao = Menu.MenuPrincipal();
            Peca PecaAux;
            Servico ServicoAux = new Servico();
            Guid cod;
            int qtd;
            switch(operacao){
                case 1:
                    //1- Registrar Peça no estoque
                    PecaAux = new Peca();
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
                    //2- Registrar um serviço no catálogo
                    ServicoAux = new Servico();
                    Console.Write("\n Nome: ");
                    ServicoAux.Nome = Console.ReadLine();
                    Console.Write("\n Preco: ");
                    ServicoAux.Preco = Convert.ToSingle(Console.ReadLine());
                    Menu.AdicionarAoBanco(ServicoAux);
                    break;
                case 3:
                    //3- Registrar um pedido
                    Pedido pedido = new Pedido();
                    Console.WriteLine("Escolha as peças do pedido pelo ID: ");
                    Peca.Read();
                    break;
                case 4:
                    //4- Cadastrar Cliente
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
                    //5- Mostrar todos os pedidos
                    Peca.Read();
                    break;
                case 6: 
                    //6- Vender Peca
                    cod = Guid.Parse(Console.ReadLine());
                    qtd = Int32.Parse(Console.ReadLine());
                    Peca.Vender(cod, qtd);
                    break;
                case 0:
                    Console.WriteLine("Obrigada por escolher nosso sistema! :) ");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }
        }
    }
}
