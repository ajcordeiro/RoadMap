using RoadMap.Clientes;
using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Model;
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
                Console.WriteLine(" ==================================");
                Console.WriteLine(" |         Web Controle           |");
                Console.WriteLine(" |================================|");
                Console.WriteLine(" | 1 - Cliente                    |");
                Console.WriteLine(" | 2 - Produto                    |");
                Console.WriteLine(" | 3 - Sair do Programa           |");
                Console.WriteLine(" ==================================");
                Console.WriteLine();
                Console.Write(" Digite sua opção: ");

                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        menuCliente.CabecalhoMenuCliente();
                            
                       // function.CabecalhoMenuCliente();
                        break;
                    case "2":

                        break;
                    case "3":
                        Console.WriteLine(" Obrigado por utilizar o programa.");
                        Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        Environment.Exit(3);
                        break;
                    default:
                        Console.WriteLine("Opção de menu inválida!");
                        break;
                }
            } while (opcao != "3");
        }
    }
}
