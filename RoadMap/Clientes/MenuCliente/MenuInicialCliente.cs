using RoadMap.Clientes.Validacoes;
using RoadMap.Menu;
using RoadMap.MenuInicial;
using System;

namespace RoadMap.Clientes.MenuCliente
{
    public class MenuInicialCliente : IMenu
    {
        public static Function function = new Function();
        static string titulo = "Controle de Cliente";



        public static void WriteOptions()
        {
            Tela.DrawScreen();

            Console.SetCursorPosition(32, 1);
            Console.WriteLine(titulo);

            Console.SetCursorPosition(2, 6);
            Console.WriteLine("1 - Cadastrar");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("2 - Editar");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("3 - Deletar");
            Console.SetCursorPosition(2, 9);
            Console.WriteLine("4 - Pesquisar");
            Console.SetCursorPosition(2, 11);
            Console.Write("Digite sua opção: ");

            string opcao = ValidacoesCliente.lerNumeros();
            MenuOptions(opcao);
        }

        private static void MenuOptions(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    Console.Clear();
                    Controller.CadastrarCliente.WriteOptions();
                    break;

                case "2":
                    Console.Clear();
                    Controller.EditarCliente.WriteOptions();
                    break;

                case "3":
                    Console.Clear();

                    Controller.DeletarCliente.WriteOptions();
                    break;

                case "4":
                    MenuInicialPesquisaCliente.CabecalhoMenuPesquisar();
                    break;

                case "F12":
                    Console.Clear();
                   
                    MenuAbertura.WriteOptions();
                    break;

                case "ESC":
                    MenuSair.ExitMenu(titulo);
                    break;

                default:
                    Console.WriteLine("\n");
                    Console.WriteLine(" Opção de menu inválida!");
                    Console.Write(" Pressione qualquer tecla para prosseguir.");
                    Console.ReadKey();
                    break;
            }
        }
    }
}
