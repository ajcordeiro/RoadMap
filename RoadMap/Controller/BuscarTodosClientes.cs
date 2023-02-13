using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Model;
using RoadMap.MenuInicial;
using System;

namespace RoadMap.Controller
{
    public class BuscarTodosClientes
    {
        public static void BuscarTodos()
        {
            MenuAbertura.DrawScreen();
            WriteOptions();
        }
        public static void GetAll(string all)
        {
            var clientesNaoEncontrados = Cliente.ListaClientes;

            Console.WriteLine(" Resultado da pesquisa:\n ");

            foreach (var cliente in clientesNaoEncontrados)
            {
                Console.WriteLine($" Cliente: {cliente.Nome.ToUpper()}");
                Console.WriteLine($" CPF: {Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");
                Console.WriteLine($" Email: {cliente.Email.ToUpper()}");
                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)00000\-0000")}");
                Console.WriteLine($" Endereço: {cliente.Endereco.ToUpper()} - Complemento: {cliente.Complemento.ToUpper()}");
                Console.WriteLine($" Cep: {cliente.Cep} - Bairro: {cliente.Bairro.ToUpper()} - Cidade: {cliente.Cidade.ToLower()}");
                Console.WriteLine();
                Console.WriteLine("------------------------------------------------------");
            }

            if (clientesNaoEncontrados.Count == 0)
            {
                Console.WriteLine(" Clientes não cadastrados na base!");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
            else
            {
                Console.Write(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
        }

        //public static void DrawScreen()
        //{
        //    Console.Clear();

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
            Console.WriteLine("Pesquisar Todos");
            Console.SetCursorPosition(1, 2);
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(2, 4);
            Console.Write("Digite sua opção: ");

            string all = string.Empty;
            GetAll(all);
        }
    }
}
