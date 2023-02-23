using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Model;
using RoadMap.Menu;
using RoadMap.MenuInicial;
using RoadMap.View;
using System;

namespace RoadMap.Controller
{
    public class BuscarTodosClientes
    {
        static string titulo = "PESQUISAR TODOS";
        
        public static void WriteOptions()
        {
            Tela.DrawScreen(titulo);

            Console.SetCursorPosition(2, 6);
            Console.Write("Digite sua opção: ");

            string all = string.Empty;
            GetAll(all);
        }

        private static void GetAll(string all)
        {
            var clientesNaoEncontrados = Cliente.ListaClientes;

            Console.SetCursorPosition(2, 6);
            Console.WriteLine("Resultado da pesquisa: ");

            foreach (var cliente in clientesNaoEncontrados)
            {
                BuscarCliente.ResultadoBuscarCliente(cliente.Cpf, cliente.Nome, cliente.DataCadastro, cliente.Email, cliente.Telefone, cliente.Celular,
                   cliente.Endereco, cliente.Numero, cliente.Complemento, cliente.Cep, cliente.Bairro, cliente.Cidade);
            }

            if (clientesNaoEncontrados.Count == 0)
            {
                Console.SetCursorPosition(25, 6);
                Console.Write("Clientes não cadastrados na base!");
                Console.SetCursorPosition(2, 20);
                Console.Write("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.WriteOptions();
            }
            else
            {
                Console.SetCursorPosition(2, 20);
                Console.Write(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.WriteOptions();
            }
        }

    }
}
