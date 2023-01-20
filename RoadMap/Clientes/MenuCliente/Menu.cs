using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMap.Clientes.MenuCliente
{
    public class Menu : IMenu
    {
        public static Function function = new Function();
        public void CabecalhoMenuCliente()
        {
            string opcao = string.Empty;

            Console.Clear();
            Console.WriteLine(" ==================================");
            Console.WriteLine(" |       Controle de Cliente      |");
            Console.WriteLine(" ==================================");
            Console.WriteLine(" | 1 - Pesquisar por Nome         |");
            Console.WriteLine(" | 2 - Pesquisar Todos            |");
            Console.WriteLine(" | 3 - Cadastar                   |");
            Console.WriteLine(" | 4 - Editar                     |");
            Console.WriteLine(" | 5 - Deletar                    |");
            Console.WriteLine(" | 6 - Sair                       |");
            Console.WriteLine(" ==================================");
            Console.WriteLine("");
            Console.Write("Digite sua opção: ");

            opcao = Console.ReadLine().ToString();
            ProcessarOpcaoMenuCliente(opcao);
        }
        public void ProcessarOpcaoMenuCliente(string opcao)
        {
            string nome = string.Empty;

            do
            {
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" |       Pesquisar  Cliente       |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        Console.WriteLine(" Digite o Nome: ");
                        nome = Console.ReadLine().ToString();
                        function.BuscarPorNome(nome);
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" |       Pesquisar  Cliente       |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        function.BuscarTodosOsClientes();
                        break;
                    case "3":
                        function.CadastrarCliente();
                        break;
                    case "4":
                        Console.WriteLine("Digite o Nome: ");
                        nome = Console.ReadLine().ToString();
                        function.EditarCliente(nome);
                        break;
                    case "5":
                        Console.WriteLine("Digite o Nome: ");
                        nome = Console.ReadLine().ToString();
                        function.DeletarCliente(nome);
                        break;
                    case "6":
                        SairDoMenuCliente();
                        break;
                    default:
                        Console.WriteLine("Opção de menu inválida!");
                        break;
                }

            } while (opcao != "6");
        }
        public void SairDoMenuCliente()
        {
            string opcao = string.Empty;

            do
            {
                Console.WriteLine("Deseja sair S/N?");
                opcao = Console.ReadLine().ToString().ToUpper();

                switch (opcao)
                {
                    case "S":
                        Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        Program.MenuInicial();
                        break;
                    case "N":
                        CabecalhoMenuCliente();
                        break;
                    default:
                        Console.WriteLine("Opção de menu inválida!");
                        break;
                }
            } while (opcao != "S" || opcao != "N");
        }

    }
}
