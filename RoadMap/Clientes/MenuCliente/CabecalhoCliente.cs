using RoadMap.Clientes.Validacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMap.Clientes.MenuCliente
{
    public class CabecalhoCliente
    {
        public static Function function = new Function();

        //ValidacoesCliente validacao = new ValidacoesCliente();
        //public void CabecalhoMenuPesquisar()
        //{
        //    string opcao = string.Empty;
        //    string nome = string.Empty;
        //    string cpf = string.Empty;

        //    do
        //    {
        //        Console.Clear();
        //        Console.WriteLine(" ======================================================");
        //        Console.WriteLine(" |                 Pesquisar Cliente                  |");
        //        Console.WriteLine(" ======================================================");
        //        Console.WriteLine(" | 1 - Pesquisar por Nome                             |");
        //        Console.WriteLine(" | 2 - Pesquisar por CPF                              |");
        //        Console.WriteLine(" | 3 - Pesquisar Todos                                |");
        //        Console.WriteLine(" | 4 - Sair                                           |");
        //        Console.WriteLine(" ======================================================\n");
        //        Console.Write(" Digite sua opção: ");

        //        opcao = ValidacoesCliente.lerNumeros();

        //        switch (opcao)
        //        {
        //            case "1":
        //                do
        //                {
        //                    Console.Clear();
        //                    Console.WriteLine(" ======================================================");
        //                    Console.WriteLine(" |            Pesquisar Cliente Por Nome              |");
        //                    Console.WriteLine(" ======================================================\n");
        //                    Console.Write(" Digite o Nome: ");

        //                    nome = ValidacoesCliente.LerLetras();

        //                    if (ValidacoesCliente.ValidaCampoVazio(nome)) ;
        //                       // function.GetNome((nome).Trim().ToLower());

        //                } while (!ValidacoesCliente.ValidaCampoVazio(nome));

        //                break;

        //            case "2":
        //                Console.Clear();
        //                Console.WriteLine(" ======================================================");
        //                Console.WriteLine(" |              Pesquisar Cliente Por CPF             |");
        //                Console.WriteLine(" ======================================================\n");
        //                Console.Write(" Digite o CPF: ");
        //                cpf = ValidacoesCliente.lerNumeros();

        //                if (!ValidacoesCliente.ValidarCPF(cpf))
        //                {
        //                    Console.Write(" Pressione qualquer tecla para prosseguir.");
        //                    Console.ReadKey();
        //                }
        //                else
        //                {
        //                   // function.GetCpf(cpf);
        //                }
        //                break;

        //            case "3":
        //                Console.Clear();
        //                Console.WriteLine(" ======================================================");
        //                Console.WriteLine(" |                 Pesquisar Todos                    |");
        //                Console.WriteLine(" ======================================================\n");
        //                function.GetAllClientes();
        //                break;

        //            case "4":
        //               SairMenu.SairDoMenuCliente(opcao);
        //                break;

        //            default:
        //                Console.WriteLine();
        //                Console.WriteLine(" Opção de menu inválida!");
        //                Console.Write(" Pressione qualquer tecla para prosseguir.");
        //                Console.ReadKey();
        //                break;
        //        }

        //    } while (opcao != "4");
        //}
    }
}
