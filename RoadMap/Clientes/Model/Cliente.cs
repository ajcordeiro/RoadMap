using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadMap.Clientes.Model
{
    public class Cliente : Contato, IClienteTeste
    {
        public static List<Cliente> ListaClientes = new List<Cliente>();

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

        public Cliente()
        {

        }
        public Cliente(string nome, string telefone)
        {
            Nome = nome;
            Telefone = telefone;
            DataAlteracao = DateTime.Now;
        }
        public Cliente(string nome, string cpf, string telefone, string email, string endereco, string complemento, string cep, string bairro, string cidade)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Endereco = endereco;
            Complemento = complemento;
            Cep = cep;
            Bairro = bairro;
            Cidade = cidade;
            DataCadastro = DateTime.Now;
        }
        public bool CadastrarCliente(Cliente cliente)
        {
            ListaClientes.Add(cliente);
            return ListaClientes.Any();
        }

        public bool CadastrarCliente()
        {
            throw new NotImplementedException();
        }
    }
}
