using System;
using RoadMap.Menu;
using RoadMap.Controller;
using RoadMap.Clientes.Validacoes;

namespace RoadMap.Clientes.MenuCliente
{
    public static class SubMenuPesquisaCliente
    {
        private static string _titulo = "PESQUISAR CLIENTE";

        public static void WriteOptions()
        {
            string opcao = string.Empty;

            do
            {
                Tela.DrawScreen(_titulo);

                Console.SetCursorPosition(2, 6);
                Console.WriteLine("1 - Pesquisar por Nome");
                Console.SetCursorPosition(2, 7);
                Console.WriteLine("2 - Pesquisar por CPF");
                Console.SetCursorPosition(2, 8);
                Console.WriteLine("3 - Pesquisar Todos");
                Console.SetCursorPosition(2, 9);
                Console.SetCursorPosition(2, 11);
                Console.Write("Digite sua opção: ");

                opcao = ValidacoesCliente.LerNumeros();
               // if (opcao == "ESC" || opcao == "F12")
                    MenuOptions(opcao);

            } while (opcao != "3");
        }

        public static void MenuOptions(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    BuscarPorNome.WriteOptions();
                    break;

                case "2":
                    BuscarPorCPF.WriteOptions();
                    break;

                case "3":
                    BuscarTodosClientes.WriteOptions();
                    break;

                case "F12":
                    Console.Clear();
                    MenuInicialCliente.WriteOptions();
                    break;

                case "ESC":
                    MenuSair.ExitMenu(_titulo);
                    break;
            }
        }
    }
}
