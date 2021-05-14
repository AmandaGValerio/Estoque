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
                    //1- Registrar Peça no estoque
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
                    Guid cod = Guid.Parse(Console.ReadLine());
                    int qtd = Int32.Parse(Console.ReadLine());
                    Peca.Vender(cod, qtd);
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
    }
}
