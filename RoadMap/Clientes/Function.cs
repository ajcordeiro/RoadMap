using RoadMap.Clientes.Model;
using System;
using System.Linq;
using RoadMap.Clientes.Validacoes;
using RoadMap.Controller;
using RoadMap.Clientes.MenuCliente;

namespace RoadMap.Clientes
{
    public class Function : ICliente
    {
       
        public Function()
        {

        }

        //public void EditarCliente(string nomePesquisado)
        //{
        //    string nomeEditado = string.Empty;
        //    string telefoneEditado = string.Empty;
        //    string opcao = string.Empty;

        //    Console.Write(" Pesquisar Nome: ");
        //    nomePesquisado = Console.ReadLine().ToString();

        //    var clientesEncontrados = Cliente.ListaClientes.Where(cliente => cliente.Nome.Contains(nomePesquisado)).ToList();
        //    clientesEncontrados.ForEach(cliente =>
        //    {
        //        Console.Clear();
        //        Console.WriteLine(" ==================================");
        //        Console.WriteLine(" |         Alterando Cliente       |");
        //        Console.WriteLine(" |=================================|\n");

        //        Console.WriteLine($" Cliente: {cliente.Nome.ToUpper()}\n");
        //        Console.WriteLine(" Digite alteração para o nome: ");
        //        nomeEditado = Console.ReadLine().ToString();

        //        if (string.IsNullOrEmpty(nomeEditado))
        //            nomeEditado = cliente.Nome;
        //        else
        //            cliente.Nome = nomeEditado;

        //        Console.WriteLine($"Cliente: {cliente.Nome}");
        //        Console.WriteLine($" CPF:{Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");

        //        Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)\0000\-0000")}");
        //        Console.WriteLine(" Digite alteração para o Telefone: ");
        //        telefoneEditado = Console.ReadLine().ToString();

        //        if (string.IsNullOrEmpty(telefoneEditado))
        //            telefoneEditado = cliente.Telefone;
        //        else
        //            cliente.Telefone = telefoneEditado;
        //        Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)\0000\-0000")}");
        //    });
        //    if (clientesEncontrados.Count == 0)
        //    {
        //        Console.WriteLine($" Cliente {nomePesquisado.ToUpper()} não encontrado!");
        //        Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
        //        Console.ReadKey();
        //        MenuInicialCliente.CabecalhoMenuCliente();
        //    }
        //    else
        //    {
        //        Console.WriteLine($" Cliente {nomeEditado.ToUpper()} alterado com sucesso!");
        //        Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
        //        Console.ReadKey();
        //        MenuInicialCliente.CabecalhoMenuCliente();
        //    }
        //}

        //public void CadastrarCliente()
        //{
        //    string nome = string.Empty;
        //    string cpf = string.Empty;
        //    string telefone = string.Empty;
        //    string email = string.Empty;
        //    string endereco = string.Empty;
        //    string complemento = string.Empty;
        //    string cep = string.Empty;
        //    string bairro = string.Empty;
        //    string cidade = string.Empty;

        //    do
        //    {
        //        Console.Write(" Digite o nome: ");
        //        nome = ValidacoesCliente.LerLetras();
        //        Console.WriteLine();
        //        nome = nome.Trim().ToLower();

        //    } while (!ValidacoesCliente.ValidaCampoVazio(nome));

        //    do
        //    {
        //        Console.WriteLine();
        //        Console.Write(" Digite o CPF: ");
        //        cpf = ValidacoesCliente.lerNumeros();
        //        Console.WriteLine();

        //    } while (!ValidacoesCliente.ValidarCPF(cpf));

        //    do
        //    {
        //        Console.WriteLine();
        //        Console.Write(" Digite o telefone: ");
        //        telefone = ValidacoesCliente.lerNumeros();
        //        Console.WriteLine();

        //    } while (string.IsNullOrEmpty(telefone));

        //    do
        //    {
        //        Console.WriteLine();
        //        Console.Write(" Digite email: ");
        //        email = Console.ReadLine().ToString();

        //    } while (!ValidacoesCliente.ValidarEmail(email));

        //    do
        //    {
        //        Console.WriteLine();
        //        Console.Write(" Digite o endereço: ");
        //        endereco = Console.ReadLine().ToString();
        //        Console.WriteLine();

        //    } while (string.IsNullOrEmpty(endereco.TrimStart()));

        //    Console.Write(" Digite o complemento: ");
        //    complemento = Console.ReadLine().ToString();
        //    Console.WriteLine();
        //    if (string.IsNullOrEmpty(complemento.TrimStart()))
        //        complemento = "NA";

        //    do
        //    {
        //        Console.Write(" Digite o cep: ");
        //        cep = ValidacoesCliente.lerNumeros();
        //        Console.WriteLine();

        //    } while (string.IsNullOrEmpty(cep));

        //    do
        //    {
        //        Console.WriteLine();
        //        Console.Write(" Digite o bairro: ");
        //        bairro = ValidacoesCliente.LerLetras();
        //        Console.WriteLine();

        //    } while (string.IsNullOrEmpty(bairro.TrimStart()));

        //    do
        //    {
        //        Console.WriteLine();
        //        Console.Write(" Digite a cidade: ");
        //        cidade = ValidacoesCliente.LerLetras();
        //        Console.WriteLine();

        //    } while (string.IsNullOrEmpty(cidade.TrimStart()));

        //    ClienteController clienteController = new ClienteController(nome, cpf, telefone, email, endereco, complemento, cep, bairro, cidade);

        //    if (clienteController.CadastrarCliente(clienteController))
        //    {
        //        Console.WriteLine();
        //        Console.WriteLine(" Cliente cadastrado com sucesso!");
        //        Console.Write(" Pressione qualquer tecla para prosseguir.");
        //        Console.ReadKey();
        //        MenuInicialCliente.CabecalhoMenuCliente();
        //    }
        //    else
        //        Console.WriteLine(" Erro ao cadastrar cliente!");
        //}

        public void DeletarCliente()
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

        
    }
}
