using RoadMap.Clientes.Model;
using System;
using System.Linq;
using System.Text.RegularExpressions;

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
            long ValidarNumeros;

            //while (Console.ReadKey().Key == ConsoleKey.Escape)
            //{
            //    Console.WriteLine("Saindo ... ");
            //    Console.WriteLine("Pressione qualquer tecla para prosseguir.");
            //    Console.ReadKey();
            //    menuCliente.CabecalhoMenuCliente();
            //}

            do
            {
                Console.WriteLine(" Digite o nome do cliente: ");
                nome = Console.ReadLine().ToString();
                Console.WriteLine();

            } while (string.IsNullOrEmpty(nome));

            do
            {
                Console.WriteLine(" Digite o CPF: ");
                Console.WriteLine();
                ValidarNumeros = long.Parse(lerNumeros());
                cpf = ValidarNumeros.ToString();
                Console.WriteLine();

            } while (!ValidarCPF(cpf));

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Digite o telefone: ");
                //telefone = Console.ReadLine().ToString();

                ValidarNumeros = long.Parse(lerNumeros());
                telefone = ValidarNumeros.ToString();
                Console.WriteLine();

            } while (string.IsNullOrEmpty(telefone));

            do
            {
                Console.WriteLine();
                Console.WriteLine(" Digite email");
                email = Console.ReadLine().ToString();

                if (!ValidarEmail(email))
                    Console.WriteLine(" Email não é valido!");

                Console.WriteLine();

            } while (!ValidarEmail(email) || string.IsNullOrEmpty(email));

            //do
            //{
            //    Console.WriteLine(" Digite o endereço: ");
            //    endereco = Console.ReadLine().ToString();
            //    Console.WriteLine();

            //} while (string.IsNullOrEmpty(endereco));

            //do
            //{
            //    Console.WriteLine(" Digite o complemento: ");
            //    complemento = Console.ReadLine().ToString();
            //    Console.WriteLine();

            //} while (string.IsNullOrEmpty(complemento));

            do
            {
                Console.WriteLine(" Digite o cep: ");
                ValidarNumeros = long.Parse(lerNumeros());
                cep = ValidarNumeros.ToString();
                Console.WriteLine();

            } while (ValidarNumeros == 0);

            //do
            //{
            //    Console.WriteLine(" Digite o bairro: ");
            //    bairro = Console.ReadLine().ToString();
            //    Console.WriteLine();

            //} while (string.IsNullOrEmpty(bairro));

            //do
            //{
            //    Console.WriteLine(" Digite a cidade: ");
            //    cidade = Console.ReadLine().ToString();
            //    Console.WriteLine();

            //} while (string.IsNullOrEmpty(cidade));

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
            {
                Console.WriteLine(" CPF Inválido!");
                return false;
            }

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

        public static string lerNumeros()
        {
            ConsoleKeyInfo cki;
            bool continuarLoop = true;
            string entrada = "0";

            while (continuarLoop)
                if (Console.KeyAvailable)
                {
                    cki = Console.ReadKey(true);
                    switch (cki.Key)
                    {
                        case ConsoleKey.Backspace:
                            if (entrada.Length == 0)
                                continue;
                            entrada = entrada.Remove(entrada.Length - 1);
                            Console.Write("\b \b"); //Remove o último caractere digitado
                            break;
                        case ConsoleKey.Enter:
                            continuarLoop = false;
                            //entrada;
                            break;
                        case ConsoleKey key when ((ConsoleKey.D0 <= key) && (key <= ConsoleKey.D9) ||
                                                  (ConsoleKey.NumPad0 <= key) && (key <= ConsoleKey.NumPad9)):
                            entrada += cki.KeyChar;
                            Console.Write(cki.KeyChar);
                            break;
                    }
                }
            return entrada;
        }

        bool ValidarEmail(string eMail)
        {
            // Return true if strIn is in valid e-mail format.
            return Regex.IsMatch(eMail, @"^([\w-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([\w-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$");
        }

    }
}
