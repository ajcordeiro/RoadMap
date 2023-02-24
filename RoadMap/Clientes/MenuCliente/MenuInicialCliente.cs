using System;
using RoadMap.Menu;
using RoadMap.MenuInicial;
using RoadMap.Clientes.Validacoes;

namespace RoadMap.Clientes.MenuCliente
{
    public class MenuInicialCliente : IMenu
    {
        private static string _titulo = "CONTROLE DE CLIENTE";

        public static void WriteOptions()
        {
            string opcao = string.Empty;

            do
            {
                Tela.DrawScreen(_titulo);

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

                opcao = ValidacoesCliente.LerNumeros();

                MenuOptions(opcao);

            } while (opcao != "4");

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
                    Console.Clear();
                    SubMenuPesquisaCliente.WriteOptions();
                    break;

                case "F12":
                    Console.Clear();
                    MenuAbertura.WriteOptions();
                    break;

                case "ESC":
                    MenuSair.ExitMenu(_titulo);
                    break;
            }
        }
    }
}
