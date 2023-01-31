using RoadMap.Clientes.Model;
using System;
using System.Linq;
using RoadMap.Clientes.Validacoes;

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
                Console.WriteLine(" |         Alterando Cliente       |");
                Console.WriteLine(" |=================================|");
                Console.WriteLine();
                Console.WriteLine($" Cliente: {cliente.Nome.ToUpper()}");
                Console.WriteLine();
                Console.WriteLine(" Digite alteração para o nome: ");
                nomeEditado = Console.ReadLine().ToString();

                if (string.IsNullOrEmpty(nomeEditado))
                    nomeEditado = cliente.Nome;
                else
                    cliente.Nome = nomeEditado;

                Console.WriteLine($"Cliente: {cliente.Nome}");
                Console.WriteLine();
                Console.WriteLine($" CPF:{Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");

                Console.WriteLine();
                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)\0000\-0000")}");
                Console.WriteLine();
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
                Console.WriteLine($" CPF: {Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");
                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)00000\-0000")}");

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
                Console.WriteLine($" CPF: {Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");
                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)00000\-0000")}");
                Console.WriteLine($" Email: {cliente.Email}");
                Console.WriteLine($" Cep: {Convert.ToUInt64(cliente.Cep).ToString(@"00000\-000")}");
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
                Console.WriteLine($" CPF: {Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")}");
                Console.WriteLine($" Telefone:{Convert.ToUInt64(cliente.Telefone).ToString(@"(00)00000\-0000")}");

                Console.WriteLine("");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            });
            if (clientesEncontradosPorCpf.Count == 0)
            {
                Console.WriteLine("");
                Console.WriteLine($" CPF {Convert.ToUInt64(cpf.ToUpper()).ToString(@"000\.000\.000\-00")} não encontrado!");
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

            do
            {
                Console.WriteLine(" Digite o nome do cliente: ");

                nome = ValidacoesCliente.LerLetras();
                Console.WriteLine();

            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Digite o CPF: ");

                cpf = ValidacoesCliente.lerNumeros();
                Console.WriteLine();

            } while (!ValidacoesCliente.ValidarCPF(cpf));

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Digite o telefone: ");

                telefone = ValidacoesCliente.lerNumeros();
                Console.WriteLine();

            } while (string.IsNullOrEmpty(telefone));

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Digite email");
                email = Console.ReadLine().ToString();

            } while (!ValidacoesCliente.ValidarEmail(email));

            do
            {
                Console.WriteLine(" Digite o endereço: ");
                endereco = Console.ReadLine().ToString();
                Console.WriteLine();

            } while (string.IsNullOrEmpty(endereco));

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Digite o complemento: ");

                complemento = Console.ReadLine().ToString();
                Console.WriteLine();

            } while (string.IsNullOrEmpty(complemento));

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Digite o cep: ");

                cep = ValidacoesCliente.lerNumeros();
                Console.WriteLine();

            } while (string.IsNullOrEmpty(cep));

            do
            {
                Console.WriteLine(" Digite o bairro: ");

                bairro = ValidacoesCliente.LerLetras();
                Console.WriteLine();

            } while (string.IsNullOrEmpty(bairro));

            do
            {
                Console.WriteLine(" Digite a cidade: ");

                cidade = ValidacoesCliente.LerLetras();
                Console.WriteLine();

            } while (string.IsNullOrEmpty(cidade));

            Cliente cliente = new Cliente(nome, cpf, telefone, email, cep);

            if (Cliente.CadastrarCliente(cliente))
            {
                Console.WriteLine(" Cliente cadastrado com sucesso!");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
            else
                Console.WriteLine(" Erro ao cadastrar cliente!");
        }

        public void DeletarCliente()
        {
            string nomePesquisado = string.Empty;

            do
            {
                Console.WriteLine(" Digite o nome: ");
                nomePesquisado = Console.ReadLine().ToString();

            } while (string.IsNullOrEmpty(nomePesquisado));

            var deletarCliente = Cliente.LstClientes.RemoveAll(cliente => cliente.Nome == nomePesquisado);

            if (Cliente.LstClientes != null)
            {
                Console.WriteLine();
                Console.WriteLine($" Cliente {nomePesquisado.ToUpper()} deletado com sucesso!");
                Console.WriteLine();
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                menuCliente.CabecalhoMenuCliente();
            }
        }

    }
}
