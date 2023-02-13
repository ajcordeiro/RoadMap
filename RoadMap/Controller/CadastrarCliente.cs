using RoadMap.Clientes.MenuCliente;
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
            string email = string.Empty;
            string endereco = string.Empty;
            string complemento = string.Empty;
            string cep = string.Empty;
            string bairro = string.Empty;
            string cidade = string.Empty;

            do
            {
                Console.SetCursorPosition(2, 4);
                Console.Write("Digite o nome: ");
                nome = ValidacoesCliente.LerLetras();
                nome = nome.Trim().ToLower();

            } while (!ValidacoesCliente.ValidaCampoVazio(nome));

            do
            {
                Console.SetCursorPosition(2, 6);
                Console.Write("Digite o CPF: ");
                cpf = ValidacoesCliente.lerNumeros();

            } while (!ValidacoesCliente.ValidarCPF(cpf));

            do
            {
                Console.SetCursorPosition(2, 2);
                Console.Write(" Digite o telefone: ");
                telefone = ValidacoesCliente.lerNumeros();

            } while (string.IsNullOrEmpty(telefone));

            do
            {
                Console.SetCursorPosition(2, 8);
                Console.Write(" Digite email: ");
                email = Console.ReadLine().ToString();

            } while (!ValidacoesCliente.ValidarEmail(email));

            do
            {
                Console.SetCursorPosition(2, 10);
                Console.Write(" Digite o endereço: ");
                endereco = Console.ReadLine().ToString();

            } while (string.IsNullOrEmpty(endereco.TrimStart()));

            Console.SetCursorPosition(2, 12);
            Console.Write(" Digite o complemento: ");
            complemento = Console.ReadLine().ToString();

            if (string.IsNullOrEmpty(complemento.TrimStart()))
                complemento = "NA";

            do
            {
                Console.SetCursorPosition(2, 14);
                Console.Write(" Digite o cep: ");
                cep = ValidacoesCliente.lerNumeros();;

            } while (string.IsNullOrEmpty(cep));

            do
            {
                Console.SetCursorPosition(2, 16);
                Console.Write(" Digite o bairro: ");
                bairro = ValidacoesCliente.LerLetras();

            } while (string.IsNullOrEmpty(bairro.TrimStart()));

            do
            {
                Console.SetCursorPosition(2, 18);
                Console.Write(" Digite a cidade: ");
                cidade = ValidacoesCliente.LerLetras();

            } while (string.IsNullOrEmpty(cidade.TrimStart()));

            ClienteController clienteController = new ClienteController(nome, cpf, telefone, email, endereco, complemento, cep, bairro, cidade);

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
