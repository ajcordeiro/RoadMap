using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Validacoes;
using RoadMap.Menu;
using System;

namespace RoadMap.MenuInicial
{
    public class MenuAbertura
    {
        public static string titulo = "Menu Abertura";

        public static void WriteOptions()
        {
            Tela.DrawScreen();

            Console.SetCursorPosition(32, 1);
            Console.Write("Web Controle");

            Console.SetCursorPosition(2, 6);
            Console.WriteLine("1 - Cliente");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("2 - Produto  ");
            Console.SetCursorPosition(2, 9);
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
                    MenuInicialCliente.WriteOptions();
                    break;
                case "2":
                    WriteOptions(); // MAbertura(); //MenuInicialProduto.CabecalhoMenuProduto();
                    break;
                case "ESC":
                    MenuSair.ExitMenu(titulo);
                    break;
                case "F12":

                    WriteOptions();
                    break;
                default:
                    Console.WriteLine("\n");
                    Console.WriteLine(" Opção de menu inválida!");
                    Console.Write(" Pressione qualquer tecla para prosseguir.");
                    Console.ReadKey();
                    Console.Clear();
                    Tela.DrawScreen();

                    break;
            }
        }
    }
}
