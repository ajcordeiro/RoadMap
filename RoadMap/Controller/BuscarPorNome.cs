using System;
using System.Linq;
using RoadMap.Menu;
using RoadMap.Clientes.Model;
using RoadMap.Clientes.Validacoes;
using RoadMap.Clientes.MenuCliente;
using RoadMap.View;

namespace RoadMap.Controller
{
    public class BuscarPorNome
    {
        static string titulo = "PESQUISAR POR NOME";

        public static void WriteOptions()
        {
            string nome = string.Empty;

            Tela.DrawScreen(titulo);

            Console.SetCursorPosition(2, 6);
            Console.Write("Digite o nome: ");

            do
            {
                Console.SetCursorPosition(17, 6);
                nome = ValidacoesCliente.LerLetras();
                nome = nome.ToUpper().Trim();

                if (nome == "ESC" || nome == "F12")
                    MenuOptions(nome);

            } while (string.IsNullOrEmpty(nome) || nome.Length < 5);

            GetNome(nome);
            SubMenuPesquisaCliente.WriteOptions();
        }

        private static void MenuOptions(string opcao)
        {
            switch (opcao)
            {
                case "ESC":
                    MenuSair.ExitMenu(titulo);
                    break;

                case "F12":
                    Console.Clear();
                    MenuInicialCliente.WriteOptions();
                    break;
            }
        }

        private static void GetNome(string nome)
        {
            Tela.DrawScreen(titulo);

            var clientesEncontrados = Cliente.ListaClientes.Where(cliente => cliente.Nome.Contains(nome)).ToList();

            clientesEncontrados.ForEach(cliente =>
            {
                Console.SetCursorPosition(2, 6);
                Console.WriteLine("Nome Pesquisado:");
                Console.SetCursorPosition(19, 6);
                Console.Write(nome);

                BuscarCliente.ResultadoBuscarCliente(cliente.Cpf, cliente.Nome, cliente.DataCadastro, cliente.Email, cliente.Telefone, cliente.Celular,
                    cliente.Endereco, cliente.Numero, cliente.Complemento, cliente.Cep, cliente.Bairro, cliente.Cidade);
            });

            if (clientesEncontrados.Count == 0)
            {
                Console.SetCursorPosition(2, 6);
                Console.Write($"Cliente: {nome.ToUpper()} não encontrado!");
                Console.SetCursorPosition(2, 20);
                Console.Write("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
            }
        }
    }
}
