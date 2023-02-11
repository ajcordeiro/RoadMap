using RoadMap.Clientes.Validacoes;
using System;

namespace RoadMap.Clientes.MenuCliente
{
    public class Menu : IMenu
    {
        public static Function function = new Function();

        ValidacoesCliente validacao = new ValidacoesCliente();
        public void CabecalhoMenuCliente()
        {
            string opcao = string.Empty;
            string nome = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine(" ======================================================");
                Console.WriteLine(" |                Controle de Cliente                 |");
                Console.WriteLine(" |====================================================|");
                Console.WriteLine(" | 1 - Pesquisar Cliente                              |");
                Console.WriteLine(" | 2 - Cadastrar                                      |");
                Console.WriteLine(" | 3 - Editar                                         |");
                Console.WriteLine(" | 4 - Deletar                                        |");
                Console.WriteLine(" | 5 - Sair                                           |");
                Console.WriteLine(" ======================================================\n");
                Console.Write(" Digite sua opção: ");

                opcao = ValidacoesCliente.lerNumeros();

                switch (opcao)
                {
                    case "1":
                        CabecalhoMenuPesquisar();
                        break;
                    case "2":
                        Console.Clear();
                        Console.WriteLine(" ======================================================");
                        Console.WriteLine(" |                 Cadastrar  Cliente                 |");
                        Console.WriteLine(" ======================================================\n");
                        function.CadastrarCliente();
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine(" ======================================================");
                        Console.WriteLine(" |                 Editar Cliente                     |");
                        Console.WriteLine(" ======================================================\n");
                        function.EditarCliente(nome);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(" ======================================================");
                        Console.WriteLine(" |                 Deletar Cliente                    |");
                        Console.WriteLine(" ======================================================\n");
                        function.DeletarCliente();
                        break;
                    case "5":
                        SairDoMenuCliente();
                        break;
                    default:
                        Console.WriteLine("\n");
                        Console.WriteLine(" Opção de menu inválida!");
                        Console.Write(" Pressione qualquer tecla para prosseguir.");
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
                Console.WriteLine(" ======================================================");
                Console.WriteLine(" |                 Pesquisar Cliente                  |");
                Console.WriteLine(" ======================================================");
                Console.WriteLine(" | 1 - Pesquisar por Nome                             |");
                Console.WriteLine(" | 2 - Pesquisar por CPF                              |");
                Console.WriteLine(" | 3 - Pesquisar Todos                                |");
                Console.WriteLine(" | 4 - Sair                                           |");
                Console.WriteLine(" ======================================================\n");
                Console.Write(" Digite sua opção: ");

                opcao = ValidacoesCliente.lerNumeros();

                switch (opcao)
                {
                    case "1":
                        do
                        {
                            Console.Clear();
                            Console.WriteLine(" ======================================================");
                            Console.WriteLine(" |            Pesquisar Cliente Por Nome              |");
                            Console.WriteLine(" ======================================================\n");
                            Console.Write(" Digite o Nome: ");

                            nome = validacao.LerLetras();

                            if (validacao.ValidaCampoVazio(nome))
                                function.BuscarPorNome((nome).Trim().ToLower());

                        } while (!validacao.ValidaCampoVazio(nome));

                        break;

                    case "2":
                        Console.Clear();
                        Console.WriteLine(" ======================================================");
                        Console.WriteLine(" |              Pesquisar Cliente Por CPF             |");
                        Console.WriteLine(" ======================================================\n");
                        Console.Write(" Digite o CPF: ");
                        cpf = ValidacoesCliente.lerNumeros();

                        if (!ValidacoesCliente.ValidarCPF(cpf))
                        {
                            Console.Write(" Pressione qualquer tecla para prosseguir.");
                            Console.ReadKey();
                        }
                        else
                        {
                            function.BuscarPorCpf(cpf);
                        }
                        break;

                    case "3":
                        Console.Clear();
                        Console.WriteLine(" ======================================================");
                        Console.WriteLine(" |                 Pesquisar Todos                    |");
                        Console.WriteLine(" ======================================================\n");
                        function.BuscarTodosOsClientes();
                        break;

                    case "4":
                        SairDoMenuCliente();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine(" Opção de menu inválida!");
                        Console.Write(" Pressione qualquer tecla para prosseguir.");
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
                Console.WriteLine("\n");
                Console.Write(" Deseja sair [S/N]? ");
                opcao = Console.ReadLine().ToString().ToUpper();

                switch (opcao)
                {
                    case "S":
                        Program.MenuInicial();
                        break;
                    case "N":
                        CabecalhoMenuCliente();
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine(" Opção de menu inválida!");
                        Console.Write(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != "S" || opcao != "N");
        }
    }
}
