using System;
using System.Linq;
using RoadMap.Menu;
using RoadMap.Clientes.Model;
using RoadMap.Clientes.Validacoes;
using RoadMap.Clientes.MenuCliente;

namespace RoadMap.Controller
{
    public class EditarCliente
    {
        static string titulo = "Editar Cliente";
        public static void WriteOptions()
        {
            string nome = string.Empty;

            Tela.DrawScreen(titulo);

            do
            {
                Console.SetCursorPosition(2, 6);
                Console.Write("Digite o Nome: ");

                nome = ValidacoesCliente.LerLetras();
                nome = nome.TrimStart().ToUpper();

                if (nome != "ESC" && nome != "F12")
                    EditCliente(nome);
                else 
                    MenuOptions(nome);

            } while (string.IsNullOrEmpty(nome) || nome.Length < 5);
        }

        public static void EditCliente(string nomePesquisado)
        {
            string nomeEditado = string.Empty;
            string telefoneEditado = string.Empty;

            var clientesEncontrados = Cliente.ListaClientes.Where(cliente => cliente.Nome.Contains(nomePesquisado)).ToList();
            clientesEncontrados.ForEach(cliente =>
            {
                Console.SetCursorPosition(2, 5);
                Console.Write($"Cliente: {cliente.Nome.ToUpper()}\n");
                Console.SetCursorPosition(2, 6);
                Console.Write("Digite alteração para o nome:");
                nomeEditado = Console.ReadLine().ToString();

                if (string.IsNullOrEmpty(nomeEditado))
                    nomeEditado = cliente.Nome;
                else
                    cliente.Nome = nomeEditado;

                Console.WriteLine($"Cliente:{cliente.Nome}");
                Console.WriteLine($"CPF:{Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");

                Console.WriteLine($"Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)\0000\-0000")}");
                Console.WriteLine("Digite alteração para o Telefone: ");
                telefoneEditado = Console.ReadLine().ToString();

                if (string.IsNullOrEmpty(telefoneEditado))
                    telefoneEditado = cliente.Telefone;
                else
                    cliente.Telefone = telefoneEditado;
                Console.WriteLine($"Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)\0000\-0000")}");
            });
            if (clientesEncontrados.Count == 0)
            {
                Console.SetCursorPosition(2, 6);
                Console.Write($"Cliente {nomePesquisado.ToUpper()} não encontrado!");
                Console.SetCursorPosition(2, 7);
                Console.Write("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                Console.Clear();
                MenuInicialCliente.WriteOptions();
            }
            else
            {
                Console.WriteLine($"Cliente {nomeEditado.ToUpper()} alterado com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                Console.Clear();
                MenuInicialCliente.WriteOptions();
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
