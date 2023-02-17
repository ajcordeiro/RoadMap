using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Model;
using RoadMap.Clientes.Validacoes;
using RoadMap.Menu;
using System;

namespace RoadMap.Controller
{
    public class DeletarCliente
    {
        static string titulo = "Deletar Cliente";

        public static void WriteOptions()
        {
            string nome = string.Empty;

            Tela.DrawScreen();

            Console.SetCursorPosition(32, 1);
            Console.WriteLine(titulo);

            do
            {
                Console.SetCursorPosition(2, 6);
                Console.Write("Digite o Nome: ");

                nome = ValidacoesCliente.LerLetras();
                nome = nome.TrimStart().ToUpper();

                if (nome != "ESC" && nome != "F12")
                    DeleteCliente();
                else
                    MenuOptions(nome);

            } while (string.IsNullOrEmpty(nome) || nome.Length < 5);
        }

        private static void DeleteCliente()
        {
            string nomePesquisado = string.Empty;

            do
            {
                Console.WriteLine(" Digite o nome: ");
                nomePesquisado = Console.ReadLine().ToString();

            } while (string.IsNullOrEmpty(nomePesquisado));

            var deletarCliente = Cliente.ListaClientes.RemoveAll(cliente => cliente.Nome == nomePesquisado);

            if (Cliente.ListaClientes != null)
            {
                Console.WriteLine($" Cliente {nomePesquisado.ToUpper()} deletado com sucesso!");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
        }

        private static void MenuOptions(string opcao)
        {
            switch (opcao)
            {
                case "F12":
                    Console.Clear();
                    MenuInicialCliente.WriteOptions();
                    break;

                case "ESC":
                    MenuSair.ExitMenu(titulo);
                    break;
            }
        }
    }
}

