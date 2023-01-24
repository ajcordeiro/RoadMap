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
                Console.WriteLine(" | 1 - Pesquisar por Nome         |");
                Console.WriteLine(" | 2 - Pesquisar Todos            |");
                Console.WriteLine(" | 3 - Cadastrar                  |");
                Console.WriteLine(" | 4 - Editar                     |");
                Console.WriteLine(" | 5 - Deletar                    |");
                Console.WriteLine(" | 6 - Sair                       |");
                Console.WriteLine(" ==================================");
                Console.WriteLine("");
                Console.Write(" Digite sua opção: ");

                opcao = Console.ReadLine().ToString();

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
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" |       Cadastrar  Cliente       |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        function.CadastrarCliente();
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" |       Editar Cliente           |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        function.EditarCliente(nome);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine(" ==================================");
                        Console.WriteLine(" |       Deletar Cliente          |");
                        Console.WriteLine(" ==================================");
                        Console.WriteLine("");
                        function.DeletarCliente();
                        break;
                    case "6":
                        SairDoMenuCliente();
                        break;
                    default:
                        Console.WriteLine(" Opção de menu inválida!");
                        Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
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
