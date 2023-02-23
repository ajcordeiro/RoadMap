using System;
using System.Linq;
using RoadMap.Clientes.Model;
using RoadMap.Clientes.Validacoes;
using RoadMap.Clientes.MenuCliente;
using RoadMap.Menu;
using RoadMap.View;

namespace RoadMap.Controller
{
    public static class BuscarPorCPF
    {
        private static string _titulo = "PESQUISAR POR CPF";

        public static void WriteOptions()
        {
            Tela.DrawScreen(_titulo);

            Console.SetCursorPosition(2, 6);
            Console.Write("Digite o CPF: ");

            string cpf = ValidacoesCliente.LerNumeros();
            GetCPF(cpf);
        }

        private static void GetCPF(string cpf)
        {
            var clientesEncontradosPorCpf = Cliente.ListaClientes.Where(cliente => cliente.Cpf.Contains(cpf)).ToList();

            clientesEncontradosPorCpf.ForEach(cliente =>
            {
                BuscarCliente.ResultadoBuscarCliente(cliente.Cpf, cliente.Nome, cliente.DataCadastro, cliente.Email, cliente.Telefone, cliente.Celular,
                    cliente.Endereco, cliente.Numero, cliente.Complemento, cliente.Cep, cliente.Bairro, cliente.Cidade);
                
                MenuInicialCliente.WriteOptions();
            });
            if (clientesEncontradosPorCpf.Count == 0)
            {
                string FormatarCpf(string Cpf) => cpf.Substring(0, 3) + "." + cpf.Substring(3, 3) + "." + cpf.Substring(6, 3) + "-" + cpf.Substring(9, 2);

                Console.SetCursorPosition(2, 6);
                Console.Write($"CPF: {FormatarCpf(cpf)} não encontrado!");
                Console.SetCursorPosition(2, 20);
                Console.Write("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.WriteOptions();
            }
        }
    }
}
