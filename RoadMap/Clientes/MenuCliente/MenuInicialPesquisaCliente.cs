using RoadMap.Clientes.Validacoes;
using RoadMap.Controller;
using RoadMap.MenuInicial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMap.Clientes.MenuCliente
{
    public static class MenuInicialPesquisaCliente
    {
        public static Function function = new Function();

        public static void CabecalhoMenuPesquisar()
        {
            string opcao = string.Empty;
            string nome = string.Empty;
            string cpf = string.Empty;

            do
            {
                Console.Clear();
                MenuAbertura.DrawScreen();
                WriteOptions();
                
            } while (opcao != "4");
        }

        //public static void DrawScreen()
        //{
        //    Console.Write("+");
        //    for (int i = 0; i <= 80; i++)
        //    {
        //        Console.Write("-");
        //    }
        //    Console.Write("+");
        //    Console.Write("\n");

        //    for (int lines = 0; lines <= 20; lines++)
        //    {
        //        Console.Write("|");
        //        for (int i = 0; i <= 80; i++)
        //        {
        //            Console.Write(" ");
        //        }
        //        Console.Write("|");
        //        Console.Write("\n");
        //    }

        //    Console.Write("+");
        //    for (int i = 0; i <= 80; i++)
        //    {
        //        Console.Write("-");
        //    }
        //    Console.Write("+");
        //}

        public static void WriteOptions()
        {
            Console.SetCursorPosition(32, 1);
            Console.WriteLine("Pesquisar Cliente");
            Console.SetCursorPosition(1, 2);
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(2, 4);
            Console.WriteLine("1 - Pesquisar por Nome");
            Console.SetCursorPosition(2, 5);
            Console.WriteLine("2 - Pesquisar por CPF");
            Console.SetCursorPosition(2, 6);
            Console.WriteLine("3 - Pesquisar Todos");
            Console.SetCursorPosition(2, 7);
            Console.WriteLine("4 - Sair");
            Console.SetCursorPosition(2, 8);
            Console.WriteLine("5 - Voltar ao Inicio");
            Console.SetCursorPosition(2, 10);
            Console.Write("Digite sua opção: ");

            string opcao = ValidacoesCliente.lerNumeros();
            HandleMenuOptions(opcao);
        }

        public static void HandleMenuOptions(string opcao)
        {
            switch (opcao)
            {
                case "1":
                    BuscarPorNome.PesquisarNome();
                    break;
                case "2":
                    BuscarPorCPF.PesquisarCPF();
                    break;
                case "3":
                    BuscarTodosClientes.BuscarTodos();
                    break;
                case "4":
                    SairMenu.SairDoMenuCliente(opcao);
                    break;
                default:
                    Console.WriteLine("\n");
                    Console.WriteLine("Opção de menu inválida!");
                    Console.Write("Pressione qualquer tecla para prosseguir.");
                    Console.ReadKey();
                    Console.Clear();
                    MenuAbertura.DrawScreen();
                    WriteOptions();
                    break;
            }
        }
    }
}
