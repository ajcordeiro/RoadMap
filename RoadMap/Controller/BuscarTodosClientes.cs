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
            Tela.DrawScreen();
            WriteOptions();
        }
        public static void WriteOptions()
        {
            Console.SetCursorPosition(32, 1);
            Console.WriteLine("Pesquisar Todos");

           // MenuAbertura.header();

            Console.SetCursorPosition(2, 6);
            Console.Write("Digite sua opção: ");

            string all = string.Empty;
            GetAll(all);
        }

        public static void GetAll(string all)
        {
            var clientesNaoEncontrados = Cliente.ListaClientes;

            Console.WriteLine(" Resultado da pesquisa:\n ");

            foreach (var cliente in clientesNaoEncontrados)
            {
                Console.WriteLine($" CPF: {Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")} - Data do Cadastro: {cliente.DataCadastro}");
                Console.WriteLine($" Cliente: {cliente.Nome.ToUpper()}");
                Console.WriteLine($" Email: {cliente.Email.ToUpper()}");
                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)0000\-0000")} - Celular: {Convert.ToUInt64(cliente.Celular).ToString(@"(00)00000\-0000")}");
                Console.WriteLine($" Endereço: {cliente.Endereco.ToUpper()} -  Nº: {cliente.Numero} - Complemento: {cliente.Complemento.ToUpper()}");
                Console.WriteLine($" Cep: {cliente.Cep} - Bairro: {cliente.Bairro.ToUpper()} - Cidade: {cliente.Cidade.ToUpper()}");
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

    }
}
