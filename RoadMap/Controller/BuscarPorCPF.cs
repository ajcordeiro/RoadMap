﻿using RoadMap.Clientes.MenuCliente;
using RoadMap.Clientes.Model;
using RoadMap.Clientes.Validacoes;
using RoadMap.MenuInicial;
using System;
using System.Linq;

namespace RoadMap.Controller
{
    public static class BuscarPorCPF
    {
        public static void PesquisarCPF()
        {
            Tela.DrawScreen();
            WriteOptions();
        }
                
        public static void WriteOptions()
        {
            Console.SetCursorPosition(32, 1);
            Console.WriteLine("Pesquisar por CPF");

           // MenuAbertura.header();

            Console.SetCursorPosition(2, 6);
            Console.Write("Digite sua opção: ");

            string cpf = ValidacoesCliente.lerNumeros();
            GetCPF(cpf);
        }

        public static void GetCPF(string cpf)
        {
            var clientesEncontradosPorCpf = Cliente.ListaClientes.Where(cliente => cliente.Cpf.Contains(cpf)).ToList();

            clientesEncontradosPorCpf.ForEach(cliente =>
            {
                Console.WriteLine("\n");
                Console.WriteLine("Resultado da pesquisa:\n");

                Console.WriteLine($" CPF: {Convert.ToUInt64(cliente.Cpf).ToString(@"000\.000\.000\-00")} - Data do Cadastro: {cliente.DataCadastro}");
                Console.WriteLine($" Cliente: {cliente.Nome.ToUpper()}");
                Console.WriteLine($" Email: {cliente.Email.ToUpper()}");
                Console.WriteLine($" Telefone: {Convert.ToUInt64(cliente.Telefone).ToString(@"(00)0000\-0000")} - Celular: {Convert.ToUInt64(cliente.Celular).ToString(@"(00)00000\-0000")}");
                Console.WriteLine($" Endereço: {cliente.Endereco.ToUpper()} -  Nº: {cliente.Numero} - Complemento: {cliente.Complemento.ToUpper()}");
                Console.WriteLine($" Cep: {cliente.Cep} - Bairro: {cliente.Bairro.ToUpper()} - Cidade: {cliente.Cidade.ToUpper()}");
                Console.WriteLine();
                Console.Write("Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            });
            if (clientesEncontradosPorCpf.Count == 0)
            {
                Console.WriteLine("\n");
                Console.WriteLine($" CPF {Convert.ToUInt64(cpf.ToUpper()).ToString(@"000\.000\.000\-00")} não encontrado!");
                Console.WriteLine(" Pressione qualquer tecla para prosseguir.");
                Console.ReadKey();
                MenuInicialCliente.CabecalhoMenuCliente();
            }
        }
    }
}
