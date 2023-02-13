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
    public class EditarCliente
    {
        public EditarCliente()
        {
            
        }
        public static void EditCliente(string nomePesquisado)
        {
            string nomeEditado = string.Empty;
            string telefoneEditado = string.Empty;
            
            var clientesEncontrados = Cliente.ListaClientes.Where(cliente => cliente.Nome.Contains(nomePesquisado)).ToList();
            clientesEncontrados.ForEach(cliente =>
            {
                Console.SetCursorPosition(1, 5);
                Console.WriteLine($" Cliente: {cliente.Nome.ToUpper()}\n");
                Console.SetCursorPosition(1, 6);
                Console.Write(" Digite alteração para o nome: ");
                nomeEditado = Console.ReadLine().ToString();

                if (string.IsNullOrEmpty(nomeEditado))
                    nomeEditado = cliente.Nome;
                else
                    cliente.Nome = nomeEditado;

                Console.WriteLine($"Cliente: {cliente.Nome}");
                Console.WriteLine($" CPF:{Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");

                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)\0000\-0000")}");
                Console.WriteLine(" Digite alteração para o Telefone: ");
                telefoneEditado = Console.ReadLine().ToString();

                if (string.IsNullOrEmpty(telefoneEditado))
                    telefoneEditado = cliente.Telefone;
                else
                    cliente.Telefone = telefoneEditado;
                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)\0000\-0000")}");
            });
            if (clientesEncontrados.Count == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine($" Cliente {nomePesquisado.ToUpper()} não encontrado!");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
            else
            {
                Console.WriteLine($" Cliente {nomeEditado.ToUpper()} alterado com sucesso!");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
        }

        public static void WriteOptions()
        {
            MenuAbertura.DrawScreen();

            Console.SetCursorPosition(32, 1);
            Console.WriteLine("Editar Cliente");
            Console.SetCursorPosition(1, 2);
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
            Console.SetCursorPosition(2, 4);
            Console.Write("Pesquisar Nome: ");


            string opcao = ValidacoesCliente.LerLetras();
            EditCliente(opcao);
            // HandleMenuOptions(opcao);
        }
    }
}
