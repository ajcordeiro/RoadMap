using System;
using RoadMap.Menu;
using RoadMap.Clientes.Validacoes;
using RoadMap.Clientes.MenuCliente;
using System.ComponentModel;
using System.Runtime.ConstrainedExecution;

namespace RoadMap.Controller
{
    public class CadastrarCliente
    {
        private static string _titulo = "CASDASTRAR CLIENTE";

        public static void WriteOptions()
        {
            Tela.DrawScreen(_titulo);

            AddCliente();
        }
        private static void AddCliente()
        {
            string nome = string.Empty;
            string cpf = string.Empty;
            string telefone = string.Empty;
            string celular = string.Empty;
            string email = string.Empty;
            string endereco = string.Empty;
            string numero = string.Empty;
            string complemento = string.Empty;
            string cep = string.Empty;
            string bairro = string.Empty;
            string cidade = string.Empty;

            Console.SetCursorPosition(2, 6);
            Console.Write("CPF:");

            Console.SetCursorPosition(2, 8);
            Console.Write("Nome:");

            Console.SetCursorPosition(39, 8);
            Console.Write("Email:");

            Console.SetCursorPosition(2, 10);
            Console.Write("Telefone:");

            Console.SetCursorPosition(39, 10);
            Console.Write("Celular:");

            Console.SetCursorPosition(2, 12);
            Console.Write("Endereço:");

            Console.SetCursorPosition(39, 12);
            Console.Write("Nº:");

            Console.SetCursorPosition(2, 14);
            Console.Write("Complemento:");

            Console.SetCursorPosition(39, 14);
            Console.Write("Cep:");

            Console.SetCursorPosition(2, 16);
            Console.Write("Bairro:");

            Console.SetCursorPosition(39, 16);
            Console.Write("Cidade:");

            do
            {
                Console.SetCursorPosition(7, 6);
                cpf = ValidacoesCliente.LerNumeros();
                cpf = cpf.Trim();

                if (cpf == "ESC" || cpf == "F12")
                    MenuOptions(cpf);
            }
            while (!ValidacoesCliente.ValidarCPF(cpf) || string.IsNullOrEmpty(cpf));

            string FormatarCpf(string Cpf) => cpf.Substring(0, 3) + "." + cpf.Substring(3, 3) + "." + cpf.Substring(6, 3) + "-" + cpf.Substring(9, 2);

            Console.SetCursorPosition(7, 6);
            Console.Write(FormatarCpf(cpf));

            do
            {
                Console.SetCursorPosition(8, 8);
                nome = ValidacoesCliente.LerLetras();
                nome = nome.ToUpper().Trim();

                if (nome == "ESC" || nome == "F12")
                    MenuOptions(nome);

            } while (string.IsNullOrEmpty(nome) || nome.Length < 5);

            Console.SetCursorPosition(8, 8);
            Console.Write(nome);

            do
            {
                Console.SetCursorPosition(46, 8);
                email = ValidacoesCliente.LerCampos();
                email = email.ToUpper().Trim();

                if (email == "ESC" || email == "F12")
                    MenuOptions(email);

            } while (!ValidacoesCliente.ValidarEmail(email));

            Console.SetCursorPosition(46, 8);
            Console.Write(email);

            Console.SetCursorPosition(12, 10);
            telefone = ValidacoesCliente.LerNumeros();
            telefone = telefone.Trim();

            if (telefone == "ESC" || telefone == "F12")
                MenuOptions(telefone);

            if (string.IsNullOrEmpty(telefone))
            {
                telefone = "000000000000";
                string FormataTelefone(string Telefone) => "(" + telefone.Substring(0, 2) + ")" + telefone.Substring(2, 4) + "-" + telefone.Substring(6, 4);
                Console.SetCursorPosition(12, 10);
                Console.Write(FormataTelefone(telefone));
            }
            else
            {
                string FormataTelefone(string Telefone) => "(" + telefone.Substring(0, 2) + ")" + telefone.Substring(2, 4) + "-" + telefone.Substring(6, 4);
                Console.SetCursorPosition(12, 10);
                Console.Write(FormataTelefone(telefone));
            }

            do
            {
                Console.SetCursorPosition(48, 10);
                celular = ValidacoesCliente.LerNumeros();
                celular = celular.Trim();

                if (celular == "ESC" || celular == "F12")
                    MenuOptions(celular);

            } while (string.IsNullOrEmpty(celular) || celular.Length < 11);

            string FormataCelular(string Celular) => "(" + celular.Substring(0, 2) + ")" + celular.Substring(2, 5) + "-" + celular.Substring(7, 4);

            Console.SetCursorPosition(48, 10);
            Console.Write(FormataCelular(celular));

            do
            {
                Console.SetCursorPosition(12, 12);
                endereco = Console.ReadLine().ToString();
                endereco = endereco.ToUpper().Trim();

                if (endereco == "ESC" || endereco == "F12")
                    MenuOptions(endereco);

            } while (string.IsNullOrEmpty(endereco) || endereco.Length < 5);

            Console.SetCursorPosition(12, 12);
            Console.Write(endereco);

            do
            {
                Console.SetCursorPosition(43, 12);
                numero = ValidacoesCliente.LerCampos();
                numero = numero.ToUpper().Trim();

                if (numero == "ESC" || numero == "F12")
                    MenuOptions(numero);

            } while (string.IsNullOrEmpty(numero) || numero.Length < 1);

            Console.SetCursorPosition(43, 12);
            Console.Write(numero);

            Console.SetCursorPosition(15, 14);
            complemento = Console.ReadLine().ToString();
            complemento = complemento.ToUpper().Trim();

            if (complemento == "ESC" || complemento == "F12")
                MenuOptions(complemento);

            if (string.IsNullOrEmpty(complemento))
            {
                complemento = "NA";
                Console.SetCursorPosition(15, 14);
                Console.Write(complemento);
            }

            Console.SetCursorPosition(15, 14);
            Console.Write(complemento);

            do
            {
                Console.SetCursorPosition(44, 14);
                cep = ValidacoesCliente.LerNumeros();
                cep = cep.Trim();

                if (cep == "ESC" || cep == "F12")
                    MenuOptions(cep);

            } while (string.IsNullOrEmpty(cep) || cep.Length < 8);

            string FormataCep(string Cep) => cep.Substring(0, 5) + "-" + cep.Substring(5, 3);

            Console.SetCursorPosition(44, 14);
            Console.WriteLine(FormataCep(cep));

            do
            {
                Console.SetCursorPosition(10, 16);
                bairro = ValidacoesCliente.LerLetras();
                bairro = bairro.ToUpper().Trim();

                if (bairro == "ESC" || bairro == "F12")
                    MenuOptions(bairro);

            } while (string.IsNullOrEmpty(bairro) || bairro.Length < 5);

            Console.SetCursorPosition(10, 16);
            Console.Write(bairro);

            do
            {
                Console.SetCursorPosition(47, 16);
                cidade = ValidacoesCliente.LerLetras();
                cidade = cidade.ToUpper().Trim();

                if (cidade == "ESC" || cidade == "F12")
                    MenuOptions(cidade);

            } while (string.IsNullOrEmpty(cidade) || cidade.Length < 5);

            Console.SetCursorPosition(47, 16);
            Console.Write(cidade);

            if (GravarDados(nome, cpf, telefone, celular, email, endereco, numero, complemento, cep, bairro, cidade))
            {
                Console.SetCursorPosition(2, 20);
                Console.Write("Cliente cadastrado com sucesso!");
                Console.SetCursorPosition(2, 21);
                Console.Write("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
            }
            
        }

        private static bool GravarDados(string nome, string cpf, string telefone, string celular,
        string email, string endereco, string numero, string complemento, string cep, string bairro,
        string cidade)
        {
            string opcao = string.Empty;
            bool retorno = false;
            Console.SetCursorPosition(2, 20);
            Console.Write("Gravar cadastro [S/N]: ");
            opcao = ValidacoesCliente.ValidaMenuSair();
            opcao = opcao.ToUpper();

            switch (opcao)
            {
                case "S":
                    ClienteController clienteController = new ClienteController(nome, cpf, telefone, celular, email, endereco, numero, complemento, cep, bairro, cidade);
                    if (clienteController.CadastrarCliente(clienteController))
                    {
                        retorno = true;
                    }
                    else
                    {
                        Console.SetCursorPosition(2, 20);
                        Console.Write("Erro ao cadastrar cliente!");
                        retorno = false;
                    }
                    break;

                case "N":
                    Console.SetCursorPosition(2, 20);
                    Console.Write("Dados não cadastrados!");
                    Console.SetCursorPosition(2, 21);
                    Console.Write("Pressione qualquer tecla para prosseguir.");
                    Console.ReadKey();
                    break;
            }
            return retorno;
        }



        private static void MenuOptions(string opcao)
        {
            switch (opcao)
            {
                case "ESC":
                    MenuSair.ExitMenu(_titulo);
                    break;

                case "F12":
                    Console.Clear();
                    MenuInicialCliente.WriteOptions();
                    break;
            }
        }
    }
}
