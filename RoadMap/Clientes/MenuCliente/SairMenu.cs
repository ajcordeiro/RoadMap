using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMap.Clientes.MenuCliente
{
    public static class SairMenu
    {
        public static void SairDoMenuCliente(string opcao)
        {
            string sair = string.Empty;
            sair = opcao;
            do
            {
                Console.WriteLine("\n");
                Console.Write(" Deseja sair [S/N]? ");
                sair = Console.ReadLine().ToString().ToUpper();

                switch (sair)
                {
                    case "S":
                        Console.WriteLine("\n");
                        Console.WriteLine(" Obrigado por utilizar o programa.");
                        Console.Write(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        Environment.Exit(0);

                        break;
                    case "N":
                       // CabecalhoMenuPesquisar();
                        break;
                    case "3":
                        Console.WriteLine("\n");
                        Console.WriteLine(" Obrigado por utilizar o programa.");
                        Console.Write(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine();
                        Console.WriteLine(" Opção de menu inválida!");
                        Console.Write(" Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        break;
                }
            } while (opcao != "S" || opcao != "N" || opcao != "3");
        }
    }
}
