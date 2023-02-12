using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Validacoes;
using System;

namespace RoadMap.MenuInicial
{
    public static class MenuAbertura
    {
        public static void MAbertura()
        {
            DrawScreen();
            WriteOptions();
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
            Console.WriteLine(" Web Controle ");
            Console.SetCursorPosition(1, 2);
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("1 - Cliente");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("2 - Produto  ");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("3 - Sair do Programa");
            Console.SetCursorPosition(2, 8);
            Console.Write("Digite sua opção: ");

            string opcao = ValidacoesCliente.lerNumeros();
            HandleMenuOptions(opcao);
        }

        public static void HandleMenuOptions(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    MenuInicialCliente.CabecalhoMenuCliente();
                    break;
                case "2":
                    //MenuInicialProduto.CabecalhoMenuProduto();
                    break;
                case "3":
                    SairMenu.SairDoMenuCliente(opcao);
                    break;
                default:
                    Console.WriteLine("\n");
                    Console.WriteLine(" Opção de menu inválida!");
                    Console.Write(" Pressione qualquer tecla para prosseguir.");
                    Console.ReadKey();
                    Console.Clear();
                    DrawScreen();
                    WriteOptions();
                    break;
            } 
        }
    }
}
