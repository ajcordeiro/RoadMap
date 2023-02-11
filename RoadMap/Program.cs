using RoadMap.Clientes;
using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Model;
using RoadMap.Clientes.Validacoes;
using System;

namespace RoadMap
{
    public class Program
    {
        public static Menu menuCliente = new Menu();
        static void Main(string[] args)
        {
            MenuInicial();
        }

        public static void MenuInicial()
        {
            string opcao = string.Empty;
            string nome = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine(" ======================================================");
                Console.WriteLine(" |                     Web Controle                   |");
                Console.WriteLine(" |====================================================|");
                Console.WriteLine(" | 1 - Cliente                                        |");
                Console.WriteLine(" | 2 - Produto                                        |");
                Console.WriteLine(" | 3 - Sair do Programa                               |");
                Console.WriteLine(" ======================================================\n");
                Console.Write(" Digite sua opção: ");

                opcao = ValidacoesCliente.lerNumeros();

                switch (opcao)
                {
                    case "1":
                        menuCliente.CabecalhoMenuCliente();
                        break;
                    case "2":

                        break;
                    case "3":
                        Console.WriteLine("\n");
                        Console.WriteLine(" Obrigado por utilizar o programa.");
                        Console.Write(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("\n");
                        Console.WriteLine(" Opção de menu inválida!");
                        Console.Write(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != "3");
        }
    }
}
