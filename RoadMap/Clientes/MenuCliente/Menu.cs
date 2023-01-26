using System;

namespace RoadMap.Clientes.MenuCliente
{
    public class Menu : IMenu
    {
        public static Function function = new Function();
        public void CabecalhoMenuCliente()
        {
            string opcao = string.Empty;
            string nome = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine(" ==================================");
                Console.WriteLine(" |       Controle de Cliente      |");
                Console.WriteLine(" ==================================");
                Console.WriteLine(" | 1 - Pesquisar Cliente          |");
                Console.WriteLine(" | 2 - Cadastrar                  |");
                Console.WriteLine(" | 3 - Editar                     |");
                Console.WriteLine(" | 4 - Deletar                    |");
                Console.WriteLine(" | 5 - Sair                       |");
                Console.WriteLine(" ==================================");
                Console.WriteLine("");
                Console.Write(" Digite sua opção: ");

                opcao = Console.ReadLine().ToString();

                switch (opcao)
                {
                    case "1":
                        CabecalhoMenuPesquisar();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" |       Cadastrar  Cliente       |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        function.CadastrarCliente();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" |       Editar Cliente           |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        function.EditarCliente(nome);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" |       Deletar Cliente          |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        function.DeletarCliente();
                        break;
                    case "5":
                        SairDoMenuCliente();
                        break;
                    default:
                        Console.WriteLine(" Opção de menu inválida!");
                        Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != "5");
        }

        public void CabecalhoMenuPesquisar()
        {
            string opcao = string.Empty;
            string nome = string.Empty;
            string cpf = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine(" ==================================");
                Console.WriteLine(" |       Pesquisar Cliente        |");
                Console.WriteLine(" ==================================");
                Console.WriteLine(" | 1 - Pesquisar por Nome         |");
                Console.WriteLine(" | 2 - Pesquisar por CPF          |");
                Console.WriteLine(" | 3 - Pesquisar Todos            |");
                Console.WriteLine(" | 4 - Sair                       |");
                Console.WriteLine(" ==================================");
                Console.WriteLine("");
                Console.Write(" Digite sua opção: ");

                opcao = Console.ReadLine().ToString();

                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" | Pesquisar Cliente Por Nome     |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        Console.WriteLine(" Digite o Nome: ");
                        nome = Console.ReadLine().ToString();
                        function.BuscarPorNome(nome);
                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" | Pesquisar Cliente Por CPF      |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        Console.WriteLine(" Digite o CPF: ");
                        cpf = Console.ReadLine().ToString();
                        function.ValidarCPF(cpf);
                        if (function.ValidarCPF(cpf) == false)
                        {
                            Console.WriteLine();
                            Console.WriteLine(" CPF inválido!");
                            Console.WriteLine();
                            Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                            Console.ReadKey();
                        }
                        else
                            function.BuscarPorCpf(cpf);
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" | Pesquisar Todos                |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        function.BuscarTodosOsClientes();
                        break;

                    case "4":
                        SairDoMenuCliente();
                        break;

                    default:
                        Console.WriteLine(" Opção de menu inválida!");
                        Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;
                }

            } while (opcao != "4");
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
                        Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        Program.MenuInicial();
                        break;
                    case "N":
                        CabecalhoMenuCliente();
                        break;
                    default:
                        Console.WriteLine(" Opção de menu inválida!");
                        Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != "S" || opcao != "N");
        }
    }
}
