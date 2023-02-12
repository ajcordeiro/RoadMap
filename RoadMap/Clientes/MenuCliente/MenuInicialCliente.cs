using RoadMap.Clientes.Validacoes;
using RoadMap.MenuInicial;
using System;

namespace RoadMap.Clientes.MenuCliente
{
    public class MenuInicialCliente : IMenu
    {
        public static Function function = new Function();


        public static void CabecalhoMenuCliente()
        {
            string opcao = string.Empty;
            do
            {
                DrawScreen();
                WriteOptions();

            } while (opcao != "5");
        }


        public static void DrawScreen()
        {
            Console.Clear();

            Console.Write("+");
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
            Console.Write("\n");

            for (int lines = 0; lines <= 20; lines++)
            {
                Console.Write("|");
                for (int i = 0; i <= 80; i++)
                {
                    Console.Write(" ");
                }
                Console.Write("|");
                Console.Write("\n");
            }

            Console.Write("+");
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }

        public static void WriteOptions()
        {
            Console.SetCursorPosition(32, 1);
            Console.WriteLine(" Controle de Cliente  ");
            Console.SetCursorPosition(1, 2);
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("1 - Pesquisar Cliente");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("2 - Cadastrar");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("3 - Editar");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("4 - Deletar");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("5 - Sair ");
            Console.SetCursorPosition(2, 10);
            Console.Write("Digite sua opção: ");

            string opcao = ValidacoesCliente.lerNumeros();
            HandleMenuOptions(opcao);
        }

        public static void HandleMenuOptions(string opcao)
        {
            string nome = string.Empty;

            switch (opcao)
            {
                case "1":
                    // BuscarPorNome.PesquisarNome();
                    MenuInicialPesquisaCliente.CabecalhoMenuPesquisar();
                    //MenuInicialPesquisaCliente.CabecalhoMenuPesquisar();
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
                    SairMenu.SairDoMenuCliente(opcao);
                    break;
                default:
                    Console.WriteLine("\n");
                    Console.WriteLine(" Opção de menu inválida!");
                    Console.Write(" Pressione qualquer tecla para prosseguir.");
                    Console.ReadKey();
                    break;
            } //while (opcao != "5") ;
        }

    }
}
