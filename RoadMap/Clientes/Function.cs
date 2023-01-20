using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Model;
using System;
using System.Linq;

namespace RoadMap.Clientes
{
    public class Function : ICliente
    {
        MenuCliente.Menu menuCliente = new MenuCliente.Menu();
        public void EditarCliente(string nome)
        {
            throw new NotImplementedException();
        }
        public void BuscarPorNome(string nome)
        {
            //Cliente.BuscarClientePorNome(nome);
            var clientesEncontrados = Cliente.LstClientes.Where(cliente => cliente.Nome.Contains(nome)).ToList();
            // var clientesEncontrados = LstClientes.Where(cliente => cliente.Nome.Contains(nome)).ToList();

            clientesEncontrados.ForEach(cliente =>
            {
                Console.WriteLine("");
                Console.WriteLine("Resultado da pesquisa: ");

                Console.WriteLine($"Cliente: {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.Cpf}");

                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.WriteLine("Implementar o menu quer continuar a PESQUISA ?.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
                

            });
            if (clientesEncontrados.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine($"Cliente {nome.ToUpper()} não encontrado!");
                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }

        }
        public void BuscarTodosOsClientes()
        {
            var clientesNaoEncontrados = Cliente.LstClientes;

            Console.WriteLine("Resultado da pesquisa: ");
            Console.WriteLine("");
            foreach (var cliente in clientesNaoEncontrados)
            {
                Console.WriteLine($"Cliente: {cliente.Nome}");
                Console.WriteLine($"CPF: {cliente.Cpf}");
                Console.WriteLine("");
            }

            if (clientesNaoEncontrados.Count == 0)
            {
                Console.WriteLine("Clientes não cadastrados na base!");
                Console.WriteLine("");
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
            else
            {
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
        }
        public void CadastrarCliente()
        {
            string nome = string.Empty;
            string cpf = string.Empty;
            string telefone = string.Empty;
            string email = string.Empty;
            string endereco = string.Empty;
            string complemento = string.Empty;
            string cep = string.Empty;
            string bairro = string.Empty;
            string cidade = string.Empty;

            do
            {
                Console.WriteLine("Digite o nome do cliente: ");
                nome = Console.ReadLine().ToString();

            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine("Digite o CPF: ");
                cpf = Console.ReadLine().ToString();

            } while (string.IsNullOrEmpty(cpf));

            //do
            //{
            //    Console.WriteLine("Digite o telefone: ");
            //    telefone = Console.ReadLine().ToString();

            //} while (string.IsNullOrEmpty(telefone));

            //do
            //{
            //    Console.WriteLine("Digite email");
            //    email = Console.ReadLine().ToString();

            //} while (string.IsNullOrEmpty(telefone));

            //do
            //{
            //    Console.WriteLine("Digite o endereço: ");
            //    endereco = Console.ReadLine().ToString();

            //} while (string.IsNullOrEmpty(endereco));

            //do
            //{
            //    Console.WriteLine("Digite o complemento: ");
            //    complemento = Console.ReadLine().ToString();

            //} while (string.IsNullOrEmpty(complemento));

            //do
            //{
            //    Console.WriteLine("Digite o cep: ");
            //    cep = Console.ReadLine().ToString();

            //} while (string.IsNullOrEmpty(cep));

            //do
            //{
            //    Console.WriteLine("Digite o bairro: ");
            //    bairro = Console.ReadLine().ToString();

            //} while (string.IsNullOrEmpty(bairro));

            //do
            //{
            //    Console.WriteLine("Digite a cidade: ");
            //    cidade = Console.ReadLine().ToString();

            //} while (string.IsNullOrEmpty(cidade));

            Cliente cliente = new Cliente(nome, cpf);

            var resultado = Cliente.CadastrarCliente(cliente);

            if (resultado == true)
            {
                Console.WriteLine("Cliente cadastrado com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
            else
                Console.WriteLine("Erro ao cadastrar cliente!");
        }
        public void DeletarCliente(string nome)
        {
            throw new NotImplementedException();
        }

        //public void CabecalhoMenuCliente()
        //{
        //    string opcao = string.Empty;

        //    Console.Clear();
        //    Console.WriteLine(" ==================================");
        //    Console.WriteLine(" |       Controle de Cliente      |");
        //    Console.WriteLine(" ==================================");
        //    Console.WriteLine(" | 1 - Pesquisar por Nome         |");
        //    Console.WriteLine(" | 2 - Pesquisar Todos            |");
        //    Console.WriteLine(" | 3 - Cadastar                   |");
        //    Console.WriteLine(" | 4 - Editar                     |");
        //    Console.WriteLine(" | 5 - Deletar                    |");
        //    Console.WriteLine(" | 6 - Sair                       |");
        //    Console.WriteLine(" ==================================");
        //    Console.WriteLine("");
        //    Console.Write("Digite sua opção: ");

        //    opcao = Console.ReadLine().ToString();
        //    ProcessarOpcaoMenuCliente(opcao);
        //}

        //public void ProcessarOpcaoMenuCliente(string opcao)
        //{
        //    string nome = string.Empty;

        //    do
        //    {
        //        switch (opcao)
        //        {
        //            case "1":
        //                Console.Clear();
        //                Console.WriteLine(" ==================================");
        //                Console.WriteLine(" |       Pesquisar  Cliente       |");
        //                Console.WriteLine(" ==================================");
        //                Console.WriteLine("");
        //                Console.WriteLine(" Digite o Nome: ");
        //                nome = Console.ReadLine().ToString();
        //                BuscarPorNome(nome);
        //                break;
        //            case "2":
        //                Console.Clear();
        //                Console.WriteLine(" ==================================");
        //                Console.WriteLine(" |       Pesquisar  Cliente       |");
        //                Console.WriteLine(" ==================================");
        //                Console.WriteLine("");
        //                BuscarTodosOsClientes();
        //                break;
        //            case "3":
        //                CadastrarCliente();
        //                break;
        //            case "4":
        //                Console.WriteLine("Digite o Nome: ");
        //                nome = Console.ReadLine().ToString();
        //                EditarCliente(nome);
        //                break;
        //            case "5":
        //                Console.WriteLine("Digite o Nome: ");
        //                nome = Console.ReadLine().ToString();
        //                DeletarCliente(nome);
        //                break;
        //            case "6":
        //                SairDoMenuCliente();
        //                break;
        //            default:
        //                Console.WriteLine("Opção de menu inválida!");
        //                break;
        //        }

        //    } while (opcao != "6");
        //}
        //public void SairDoMenuCliente()
        //{
        //    string opcao = string.Empty;

        //    do
        //    {
        //        Console.WriteLine("Deseja sair S/N?");
        //        opcao = Console.ReadLine().ToString().ToUpper();

        //        switch (opcao)
        //        {
        //            case "S":
        //                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
        //                Console.ReadKey();
        //                Program.MenuInicial();
        //                break;
        //            case "N":
        //                CabecalhoMenuCliente();
        //                break;
        //            default:
        //                Console.WriteLine("Opção de menu inválida!");
        //                break;
        //        }
        //    } while (opcao != "S" || opcao != "N");
        //}
    }
}
