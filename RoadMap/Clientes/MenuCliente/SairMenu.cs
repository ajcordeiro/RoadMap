using RoadMap.MenuInicial;
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

            do
            {
                Console.WriteLine("\n");
                Console.Write(" Deseja sair [S/N]? ");
                sair = Console.ReadLine().ToString().ToUpper();
                if (opcao == "5" & sair == "S")
                    sair = "5";
                else
                    sair = sair;

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
                        MenuInicialCliente.CabecalhoMenuCliente();
                        break;

                    case "3":
                        Console.WriteLine("\n");
                        Console.WriteLine("Obrigado por utilizar o programa.");
                        Console.Write("Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        Environment.Exit(0);
                        break;

                    case "5":
                        Console.WriteLine("\n");
                        Console.Write("Pressione qualquer tecla para prosseguir.");
                        Console.ReadKey();
                        MenuAbertura.MAbertura();
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
