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
    public class CadastrarCliente
    {
        public static void AddCliente()
        {
            string nome = string.Empty;
            string cpf = string.Empty;
            string telefone = string.Empty;
            string celular = string.Empty;
            string email = string.Empty;
            string endereco = string.Empty;
            string complemento = string.Empty;
            string cep = string.Empty;
            string bairro = string.Empty;
            string cidade = string.Empty;

            Console.SetCursorPosition(2, 4);
            Console.Write("CPF:");

            Console.SetCursorPosition(2, 6);
            Console.Write("Nome:");

            Console.SetCursorPosition(39, 6);
            Console.Write("Email:");

            Console.SetCursorPosition(2, 8);
            Console.Write("Telefone:");

            Console.SetCursorPosition(39, 8);
            Console.Write("Celular:");

            Console.SetCursorPosition(2, 10);
            Console.Write("Endereço:");

            Console.SetCursorPosition(2, 12);
            Console.Write("Complemento:");

            Console.SetCursorPosition(39, 12);
            Console.Write("Cep:");

            Console.SetCursorPosition(2, 14);
            Console.Write("Bairro:");

            Console.SetCursorPosition(39, 14);
            Console.Write("Cidade:");

            do
            {
                Console.SetCursorPosition(7, 4);
                cpf = ValidacoesCliente.lerNumeros();
            }
            while (!ValidacoesCliente.ValidarCPF(cpf));

            Console.SetCursorPosition(7, 4);
            Console.Write(Convert.ToUInt64(cpf.ToUpper()).ToString(@"000\.000\.000\-00"));

            do
            {
                Console.SetCursorPosition(8, 6);
                nome = ValidacoesCliente.LerLetras();
                nome = nome.ToLower().Trim();

            } while (string.IsNullOrEmpty(nome) || nome.Length < 5);

            Console.SetCursorPosition(8, 6);
            Console.Write(nome);

            do
            {
                Console.SetCursorPosition(46, 6);
                email = Console.ReadLine().ToString();

            } while (!ValidacoesCliente.ValidarEmail(email));

            Console.SetCursorPosition(12, 8);
            telefone = ValidacoesCliente.lerNumeros();
            if (string.IsNullOrEmpty(telefone.TrimStart()))
            {
                telefone = "0000000000";
                Console.SetCursorPosition(12, 8);
                Console.Write(Convert.ToUInt64(telefone).ToString(@"(00)0000\-0000"));
            }

            do
            {
                Console.SetCursorPosition(48, 8);
                celular = ValidacoesCliente.lerNumeros();

            } while (string.IsNullOrEmpty(celular) || celular.Length < 11);

            Console.SetCursorPosition(48, 8);
            Console.Write(Convert.ToUInt64(celular).ToString(@"(00)00000\-0000"));

            do
            {
                Console.SetCursorPosition(12, 10);
                endereco = Console.ReadLine().ToString();

            } while (string.IsNullOrEmpty(endereco.TrimStart()) || endereco.Length < 5);

            Console.SetCursorPosition(15, 12);
            complemento = Console.ReadLine().ToString();
            if (string.IsNullOrEmpty(complemento.TrimStart()))
            {
                complemento = "NA";
                Console.SetCursorPosition(15, 12);
                Console.Write(complemento);
            }

            do
            {
                Console.SetCursorPosition(44, 12);
                cep = ValidacoesCliente.lerNumeros();

            } while (string.IsNullOrEmpty(cep) || cep.Length < 8);

            Console.SetCursorPosition(44, 12);
            Console.WriteLine(Convert.ToUInt64(cep).ToString(@"00000\-000"));

            do
            {
                Console.SetCursorPosition(10, 14);
                bairro = ValidacoesCliente.LerLetras();
            } while (string.IsNullOrEmpty(bairro.TrimStart()) || bairro.Length < 5);

            do
            {
                Console.SetCursorPosition(47, 14);
                cidade = ValidacoesCliente.LerLetras();
            } while (string.IsNullOrEmpty(cidade.TrimStart()) || cidade.Length < 5);


            ClienteController clienteController = new ClienteController(nome, cpf, telefone, celular, email, endereco, complemento, cep, bairro, cidade);

            if (clienteController.CadastrarCliente(clienteController))
            {
                Console.WriteLine();
                Console.WriteLine(" Cliente cadastrado com sucesso!");
                Console.Write(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
            else
                Console.WriteLine(" Erro ao cadastrar cliente!");
        }
        public static void WriteOptions()
        {
            MenuAbertura.DrawScreen();

            Console.SetCursorPosition(32, 1);
            Console.WriteLine("Cadastrar Cliente");
            Console.SetCursorPosition(1, 2);
            for (int i = 0; i <= 80; i++)
            {
                Console.Write("=");
            }
            //Console.SetCursorPosition(2, 4);
            //Console.Write("Pesquisar Nome: ");


            //string opcao = ValidacoesCliente.LerLetras();
            AddCliente();
        }
    }
}
