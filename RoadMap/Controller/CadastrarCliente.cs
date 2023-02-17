using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Validacoes;
using RoadMap.Menu;
using RoadMap.MenuInicial;
using System;
using System.Diagnostics.Tracing;

namespace RoadMap.Controller
{
    public class CadastrarCliente
    {
        static string titulo = "Cadastrar Cliente";

        public static void WriteOptions()
        {
            Tela.DrawScreen();

            Console.SetCursorPosition(32, 1);
            Console.WriteLine(titulo);

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

            Console.SetCursorPosition(2, 5);
            Console.Write("CPF:");

            Console.SetCursorPosition(2, 7);
            Console.Write("Nome:");

            Console.SetCursorPosition(39, 7);
            Console.Write("Email:");

            Console.SetCursorPosition(2, 9);
            Console.Write("Telefone:");

            Console.SetCursorPosition(39, 9);
            Console.Write("Celular:");

            Console.SetCursorPosition(2, 11);
            Console.Write("Endereço:");

            Console.SetCursorPosition(39, 11);
            Console.Write("Nº:");

            Console.SetCursorPosition(2, 13);
            Console.Write("Complemento:");

            Console.SetCursorPosition(39, 13);
            Console.Write("Cep:");

            Console.SetCursorPosition(2, 15);
            Console.Write("Bairro:");

            Console.SetCursorPosition(39, 15);
            Console.Write("Cidade:");

            do
            {
                Console.SetCursorPosition(7, 5);
                cpf = ValidacoesCliente.lerNumeros();

                if (cpf == "ESC" || cpf == "F12")
                    MenuOptions(cpf);
            }
            while (!ValidacoesCliente.ValidarCPF(cpf) || string.IsNullOrEmpty(cpf));

            Console.SetCursorPosition(7, 5);
            Console.Write(Convert.ToUInt64(cpf.ToUpper()).ToString(@"000\.000\.000\-00"));

            do
            {
                Console.SetCursorPosition(8, 7);
                nome = ValidacoesCliente.LerLetras();
                nome = nome.ToUpper().Trim();

                if (nome == "ESC" || nome == "F12")
                    MenuOptions(nome);

            } while (string.IsNullOrEmpty(nome) || nome.Length < 5);

            Console.SetCursorPosition(8, 7);
            Console.Write(nome);

            do
            {
                Console.SetCursorPosition(46, 7);
                email = ValidacoesCliente.LerCampos();

                if (email == "ESC" || email == "F12")
                    MenuOptions(email);

            } while (!ValidacoesCliente.ValidarEmail(email));

            Console.SetCursorPosition(12, 9);
            telefone = ValidacoesCliente.lerNumeros();

            if (telefone == "ESC" || telefone == "F12")
                MenuOptions(telefone);

            if (string.IsNullOrEmpty(telefone.TrimStart()))
            {
                telefone = "0000000000";
                Console.SetCursorPosition(12, 9);
                Console.Write(Convert.ToUInt64(telefone).ToString(@"(00)0000\-0000"));
            }

            do
            {
                Console.SetCursorPosition(48, 9);
                celular = ValidacoesCliente.lerNumeros();

                if (celular == "ESC" || celular == "F12")
                    MenuOptions(celular);

            } while (string.IsNullOrEmpty(celular) || celular.Length < 11);

            Console.SetCursorPosition(48, 9);
            Console.Write(Convert.ToUInt64(celular).ToString(@"(00)00000\-0000"));

            do
            {
                Console.SetCursorPosition(12, 11);
                endereco = Console.ReadLine().ToString();

                if (endereco == "ESC" || endereco == "F12")
                    MenuOptions(endereco);

            } while (string.IsNullOrEmpty(endereco.TrimStart()) || endereco.Length < 5);

            do
            {
                Console.SetCursorPosition(43, 11);
                numero = ValidacoesCliente.lerNumeros();

                if (numero == "ESC" || numero == "F12")
                    MenuOptions(numero);

            } while (string.IsNullOrEmpty(numero.TrimStart()) || numero.Length < 1);

            Console.SetCursorPosition(15, 13);
            complemento = Console.ReadLine().ToString();

            if (complemento == "ESC" || complemento == "F12")
                MenuOptions(complemento);

            if (string.IsNullOrEmpty(complemento.TrimStart()))
            {
                complemento = "NA";
                Console.SetCursorPosition(15, 13);
                Console.Write(complemento);
            }

            do
            {
                Console.SetCursorPosition(44, 13);
                cep = ValidacoesCliente.lerNumeros();

                if (cep == "ESC" || cep == "F12")
                    MenuOptions(cep);

            } while (string.IsNullOrEmpty(cep) || cep.Length < 8);

            Console.SetCursorPosition(44, 13);
            Console.WriteLine(Convert.ToUInt64(cep).ToString(@"00000\-000"));

            do
            {
                Console.SetCursorPosition(10, 15);
                bairro = ValidacoesCliente.LerLetras();

                if (bairro == "ESC" || bairro == "F12")
                    MenuOptions(bairro);

            } while (string.IsNullOrEmpty(bairro.TrimStart()) || bairro.Length < 5);

            do
            {
                Console.SetCursorPosition(47, 15);
                cidade = ValidacoesCliente.LerLetras();

                if (cidade == "ESC" || cidade == "F12")
                    MenuOptions(cidade);

            } while (string.IsNullOrEmpty(cidade.TrimStart()) || cidade.Length < 5);

            ClienteController clienteController = new ClienteController(nome, cpf, telefone, celular, email, endereco, numero, complemento, cep, bairro, cidade);

            if (clienteController.CadastrarCliente(clienteController))
            {
                Console.SetCursorPosition(2, 20);
                Console.Write("Cliente cadastrado com sucesso!");
                Console.SetCursorPosition(2, 21);
                Console.Write("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
            else
            {
                Console.SetCursorPosition(2, 20);
                Console.Write("Erro ao cadastrar cliente!");
            }
        }

        private static void MenuOptions(string opcao)
        {
            switch (opcao)
            {
                case "ESC":
                    MenuSair.ExitMenu(titulo);
                    break;

                case "F12":
                    Console.Clear();
                    MenuInicialCliente.WriteOptions();
                    break;

                default:
                    Console.WriteLine("\n");
                    Console.WriteLine(" Opção de menu inválida!");
                    Console.Write(" Pressione qualquer tecla para prosseguir.");
                    Console.ReadKey();
                    Console.Clear();
                    Tela.DrawScreen();

                    break;
            }
        }
    }
}
