using RoadMap.Clientes;
using RoadMap.Clientes.Model;
using System;
using System.Linq;

namespace RoadMap.Controller
{
    public class ClienteController : IClienteTeste
    {
        Cliente cliente1 = new Cliente();

        public ClienteController()
        {
           
        }
        public ClienteController(string nome, string telefone)
        {
            cliente1.Nome = nome;
            cliente1.Telefone = telefone;
            cliente1.DataAlteracao = DateTime.Now;
        }

        public ClienteController(string nome, string cpf, string telefone,string celular, string email, string endereco, string complemento, string cep, string bairro, string cidade)
        {
            cliente1.Nome = nome;
            cliente1.Cpf = cpf;
            cliente1.Telefone = telefone;
            cliente1.Celular = celular;
            cliente1.Email = email;
            cliente1.Endereco = endereco;
            cliente1.Complemento = complemento;
            cliente1.Cep = cep;
            cliente1.Bairro = bairro;
            cliente1.Cidade = cidade;
            cliente1.DataCadastro = DateTime.Now;
        }

        public bool CadastrarCliente(ClienteController cliente)
        {
            Cliente.ListaClientes.Add(cliente1);

            return Cliente.ListaClientes.Any();
        }

        public static bool BuscarPorCpf(string cpf)
        {
            var clientesEncontradosPorCpf = Cliente.ListaClientes.Where(cliente => cliente.Cpf.Contains(cpf)).ToList();

            return clientesEncontradosPorCpf.Any();

            //clientesEncontradosPorCpf.ForEach(cliente =>
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine(" Resultado da pesquisa:\n ");

            //    Console.WriteLine($" Cliente: {(cliente.Nome).ToUpper()}");
            //    Console.WriteLine($" CPF: {Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");
            //    Console.WriteLine($" Email: {(cliente.Email).ToUpper()}");
            //    Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)00000\-0000")}");
            //    Console.WriteLine($" Endereço: {(cliente.Endereco).ToUpper()} - Complemento: {(cliente.Complemento).ToUpper()}");
            //    Console.WriteLine($" Cep: {cliente.Cep} - Bairro: {(cliente.Bairro).ToUpper()} - Cidade: {(cliente.Cidade).ToLower()}");
            //    Console.WriteLine();
            //    //Console.Write(" Pressione qualquer tecla para prosseguir.");
            //    //Console.ReadKey();
            //    // menuCliente.CabecalhoMenuCliente();
            //});
            //    return true;
            //if (clientesEncontradosPorCpf.Count == 0)
            //{
            //    Console.WriteLine("\n");
            //    Console.WriteLine($" CPF {Convert.ToUInt64(cpf.ToUpper()).ToString(@"000\.000\.000\-00")} não encontrado!");
            //    //Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
            //    // Console.ReadKey();
            //    // menuCliente.CabecalhoMenuCliente();
            //    return false;
            //}

        }
    }
}
