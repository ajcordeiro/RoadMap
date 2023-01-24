using RoadMap.Clientes.Model;
using System;
using System.Linq;

namespace RoadMap.Clientes
{
    public class Function : ICliente
    {
        MenuCliente.Menu menuCliente = new MenuCliente.Menu();

        public void EditarCliente(string nomePesquisado)
        {
            string nomeEditado = string.Empty;
            string telefoneEditado = string.Empty;

            Console.WriteLine(" Pesquisar Nome: ");
            nomePesquisado = Console.ReadLine().ToString();

            var clientesEncontrados = Cliente.LstClientes.Where(cliente => cliente.Nome.Contains(nomePesquisado)).ToList();
            clientesEncontrados.ForEach(cliente =>
            {
                Console.Clear();
                Console.WriteLine(" ==================================");
                Console.WriteLine(" |       Alterando Cliente        |");
                Console.WriteLine(" ==================================");
                Console.WriteLine();
                Console.WriteLine($" Cliente: {cliente.Nome.ToUpper()}");
                Console.WriteLine();
                Console.WriteLine(" Digite alteração para o nome: ");
                nomeEditado = Console.ReadLine().ToString();

                if (string.IsNullOrEmpty(nomeEditado))
                    nomeEditado = cliente.Nome;
                else
                    cliente.Nome = nomeEditado;

                Console.WriteLine();
                Console.WriteLine($" Telefone: {cliente.Telefone}");
                Console.WriteLine();
                Console.WriteLine(" Digite alteração para o Telefone: ");
                telefoneEditado = Console.ReadLine().ToString();

                if (string.IsNullOrEmpty(telefoneEditado))
                    telefoneEditado = cliente.Telefone;
                else
                    cliente.Telefone = telefoneEditado;

                Console.WriteLine($" CPF: {cliente.Cpf}");
            });
            if (clientesEncontrados.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine($" Cliente {nomePesquisado.ToUpper()} não encontrado!");
                Console.WriteLine("");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine($" Cliente {nomeEditado.ToUpper()} alterado com sucesso!");
                Console.WriteLine();
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
        }

        public void BuscarPorNome(string nome)
        {
            var clientesEncontrados = Cliente.LstClientes.Where(cliente => cliente.Nome.Contains(nome)).ToList();

            clientesEncontrados.ForEach(cliente =>
            {
                Console.WriteLine("");
                Console.WriteLine(" Resultado da pesquisa: ");

                Console.WriteLine($" Cliente: {cliente.Nome}");
                Console.WriteLine($" CPF: {cliente.Cpf}");
                Console.WriteLine($" Telefone: {cliente.Telefone}");

                Console.WriteLine("");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            });
            if (clientesEncontrados.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine($" Cliente {nome.ToUpper()} não encontrado!");
                Console.WriteLine("");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
        }

        public void BuscarTodosOsClientes()
        {
            var clientesNaoEncontrados = Cliente.LstClientes;

            Console.WriteLine(" Resultado da pesquisa: ");
            Console.WriteLine("");
            foreach (var cliente in clientesNaoEncontrados)
            {
                Console.WriteLine($" Cliente: {cliente.Nome}");
                Console.WriteLine($" CPF: {cliente.Cpf}");
                Console.WriteLine($" Telefone: {cliente.Telefone}");
                Console.WriteLine("");
            }

            if (clientesNaoEncontrados.Count == 0)
            {
                Console.WriteLine(" Clientes não cadastrados na base!");
                Console.WriteLine("");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
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

        public void BuscarPorCpf(string cpf)
        {
            var clientesEncontradosPorCpf = Cliente.LstClientes.Where(cliente => cliente.Cpf.Contains(cpf)).ToList();

            clientesEncontradosPorCpf.ForEach(cliente =>
            {
                Console.WriteLine("");
                Console.WriteLine(" Resultado da pesquisa: ");

                Console.WriteLine($" Cliente: {cliente.Nome}");
                Console.WriteLine($" CPF: {cliente.Cpf}");
                Console.WriteLine($" Telefone: {cliente.Telefone}");

                Console.WriteLine("");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            });
            if (clientesEncontradosPorCpf.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine($" Cliente {cpf.ToUpper()} não encontrado!");
                Console.WriteLine("");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
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

            //while (Console.ReadKey().Key == ConsoleKey.Escape)
            //{
            //    Console.WriteLine("Saindo ... ");
            //    Console.WriteLine("Pressione qualquer tecla para prosseguir.");
            //    Console.ReadKey();
            //    menuCliente.CabecalhoMenuCliente();
            //}

            do
            {
                Console.WriteLine("Digite o nome do cliente: ");
                nome = Console.ReadLine().ToString();

            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine("Digite o CPF: ");
                cpf = Console.ReadLine().ToString();
                ValidarCPF(cpf);

            } while (ValidarCPF(cpf) == false);

            do
            {
                Console.WriteLine("Digite o telefone: ");
                telefone = Console.ReadLine().ToString();

            } while (string.IsNullOrEmpty(telefone));

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

            Cliente cliente = new Cliente(nome, cpf, telefone);

            if (Cliente.CadastrarCliente(cliente) == true)
            {
                Console.WriteLine("Cliente cadastrado com sucesso!");
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
            else
                Console.WriteLine("Erro ao cadastrar cliente!");
        }

        public void DeletarCliente()
        {
            string nomePesquisado = string.Empty;

            do
            {
                Console.WriteLine("Digite o nome: ");
                nomePesquisado = Console.ReadLine().ToString();

            } while (string.IsNullOrEmpty(nomePesquisado));

            var deletarCliente = Cliente.LstClientes.RemoveAll(cliente => cliente.Nome == nomePesquisado);

            if (Cliente.LstClientes != null)
            {
                Console.WriteLine();
                Console.WriteLine($"Cliente {nomePesquisado.ToUpper()} deletado com sucesso!");
                Console.WriteLine();
                Console.WriteLine("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
        }

        public bool ValidarCPF(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (cpf.Length != 11)
                return false;

            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = resto.ToString();

            tempCpf = tempCpf + digito;

            soma = 0;

            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];

            resto = soma % 11;

            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;

            digito = digito + resto.ToString();

            return cpf.EndsWith(digito);
        }
    }
}
