using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadMap.Clientes.Model
{
    public class Cliente : Contato
    {
        static Function function = new Function();

        public static List<Cliente> LstClientes = new List<Cliente>();

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public Cliente(string nome, string cpf)
        {
            Nome = nome;
            Cpf = cpf;
            DataCadastro = DateTime.Now;
        }
        public static bool CadastrarCliente(Cliente cliente)
        {
            LstClientes.Add(cliente);
            return LstClientes.Any();
        }

        //public static void BuscarClientePorNome(string nome)
        //{
        //    var clientesEncontrados = LstClientes.Where(cliente => cliente.Nome.Contains(nome)).ToList();

        //    clientesEncontrados.ForEach(cliente =>
        //    {
        //        Console.WriteLine("");
        //        Console.WriteLine("Resultado da pesquisa: ");

        //        Console.WriteLine($"Cliente: {cliente.Nome}");
        //        Console.WriteLine($"CPF: {cliente.Cpf}");

        //        Console.WriteLine("");
        //        Console.WriteLine("Pressione qualquer tecla para prosseguir.");
        //        Console.WriteLine("Implementar o menu quer continuar a PESQUISA ?.");
        //        Console.ReadKey();
        //        function.CabecalhoMenuCliente();

        //    });
        //    if (clientesEncontrados.Count == 0)
        //    {
        //        Console.WriteLine("");
        //        Console.WriteLine($"Cliente {nome.ToUpper()} não encontrado!");
        //        Console.WriteLine("");
        //        Console.WriteLine("Pressione qualquer tecla para prosseguir.");
        //        Console.ReadKey();
        //        function.CabecalhoMenuCliente();
        //    }
        //}

        //public static void BuscarTodosOsCliente()
        //{
        //    var clientesNaoEncontrados = LstClientes;

        //    Console.WriteLine("Resultado da pesquisa: ");
        //    Console.WriteLine("");
        //    foreach (var cliente in clientesNaoEncontrados)
        //    {
        //        Console.WriteLine($"Cliente: {cliente.Nome}");
        //        Console.WriteLine($"CPF: {cliente.Cpf}");
        //        Console.WriteLine("");
        //    }
            
        //    if (clientesNaoEncontrados.Count == 0)
        //    {
        //        Console.WriteLine("Clientes não encontrado!");
        //        Console.WriteLine("");
        //        Console.WriteLine("Pressione qualquer tecla para prosseguir.");
        //        Console.ReadKey();
        //        function.CabecalhoMenuCliente();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Pressione qualquer tecla para prosseguir.");
        //        Console.ReadKey();
        //        function.CabecalhoMenuCliente();
        //    }
        //}
    }
}
