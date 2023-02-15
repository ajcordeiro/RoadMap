using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Model;
using RoadMap.Clientes.Validacoes;
using RoadMap.MenuInicial;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMap.Controller
{
    public class BuscarPorNome
    {
        public static void PesquisarNome()
        {
            MenuAbertura.DrawScreen();
            WriteOptions();
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
            Console.WriteLine("Pesquisar por nome");
            Console.SetCursorPosition(1, 2);
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(2, 4);
            Console.Write("Digite sua opção: ");

            string nome = ValidacoesCliente.LerLetras();
            GetNome(nome);
        }

        public static void GetNome(string nome)
        {
            var clientesEncontrados = Cliente.ListaClientes.Where(cliente => cliente.Nome.Contains(nome)).ToList();

            clientesEncontrados.ForEach(cliente =>
            {
                Console.WriteLine("\n");
                Console.WriteLine("Resultado da pesquisa:\n ");

                Console.WriteLine($" Cliente: {cliente.Nome.ToUpper()}");
                Console.WriteLine($" CPF: {Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");
                Console.WriteLine($" Email: {cliente.Email.ToUpper()}");
                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)0000\-0000")} - Celular: {Convert.ToUInt64(cliente.Celular).ToString(@"(00)00000\-0000")}");
                Console.WriteLine($" Endereço: {cliente.Endereco.ToUpper()} - Complemento: {cliente.Complemento.ToUpper()}");
                Console.WriteLine($" Cep: {cliente.Cep} - Bairro: {cliente.Bairro.ToUpper()} - Cidade: {cliente.Cidade.ToLower()}");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            });
            if (clientesEncontrados.Count == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine($" Cliente:{nome.ToUpper()} não encontrado!");
                Console.Write(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
        }
    }
}
