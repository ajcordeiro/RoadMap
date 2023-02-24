using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Model;
using RoadMap.Menu;
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
            GetAll();
            SubMenuPesquisaCliente.WriteOptions();
        }

        private static void GetAll()
        {
            var clientesNaoEncontrados = Cliente.ListaClientes;

            foreach (var cliente in clientesNaoEncontrados)
            {
                BuscarCliente.ResultadoBuscarCliente(cliente.Cpf, cliente.Nome, cliente.DataCadastro, cliente.Email, cliente.Telefone, cliente.Celular,
                   cliente.Endereco, cliente.Numero, cliente.Complemento, cliente.Cep, cliente.Bairro, cliente.Cidade);
            }

            if (clientesNaoEncontrados.Count == 0)
            {
                Console.SetCursorPosition(2, 6);
                Console.Write("Clientes não cadastrados na base!");
                Console.SetCursorPosition(2, 20);
                Console.Write("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
            }
        }
    }
}
