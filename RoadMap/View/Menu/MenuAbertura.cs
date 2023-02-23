using System;
using RoadMap.Menu;
using RoadMap.Clientes.Validacoes;
using RoadMap.Clientes.MenuCliente;

namespace RoadMap.MenuInicial
{
    public class MenuAbertura
    {
        public static string titulo = "WEB CONTROLE";

        public static void WriteOptions()
        {
            string opcao = string.Empty;

            do
            {
                Tela.DrawScreen(titulo);

                Console.SetCursorPosition(2, 6);
                Console.WriteLine("1 - Cliente");
                Console.SetCursorPosition(2, 7);
                Console.WriteLine("2 - Produto  ");
                Console.SetCursorPosition(2, 9);
                Console.Write("Digite sua opção: ");

                opcao = ValidacoesCliente.LerNumeros();

                MenuOptions(opcao);

            } while (opcao != "2");
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
            }
        }
    }
}
