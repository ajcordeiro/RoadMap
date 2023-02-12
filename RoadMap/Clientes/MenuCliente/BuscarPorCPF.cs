using RoadMap.Clientes.Model;
using RoadMap.Clientes.Validacoes;
using System;
using System.Linq;

namespace RoadMap.Clientes.MenuCliente
{
    public static class BuscarPorCPF
    {
        public static void PesquisarCPF()
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
            Console.WriteLine("Pesquisar por CPF");
            Console.SetCursorPosition(1, 2);
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(2, 4);
            Console.Write("Digite sua opção: ");

            string cpf = ValidacoesCliente.lerNumeros();
            GetCPF(cpf);
        }

        public static void GetCPF(string cpf)
        {
            var clientesEncontradosPorCpf = Cliente.ListaClientes.Where(cliente => cliente.Cpf.Contains(cpf)).ToList();

            clientesEncontradosPorCpf.ForEach(cliente =>
            {
                Console.WriteLine("\n");
                Console.WriteLine("Resultado da pesquisa:\n");

                Console.WriteLine($" Cliente: {(cliente.Nome).ToUpper()}");
                Console.WriteLine($" CPF: {Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");
                Console.WriteLine($" Email: {(cliente.Email).ToUpper()}");
                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)00000\-0000")}");
                Console.WriteLine($" Endereço: {(cliente.Endereco).ToUpper()} - Complemento: {(cliente.Complemento).ToUpper()}");
                Console.WriteLine($" Cep: {cliente.Cep} - Bairro: {(cliente.Bairro).ToUpper()} - Cidade: {(cliente.Cidade).ToLower()}");
                Console.WriteLine();
                Console.Write(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            });
            if (clientesEncontradosPorCpf.Count == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine($" CPF {Convert.ToUInt64(cpf.ToUpper()).ToString(@"000\.000\.000\-00")} não encontrado!");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
        }
    }
}
