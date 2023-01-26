using System;
using System.Collections.Generic;
using System.Linq;

namespace RoadMap.Clientes.Model
{
    public class Cliente : Contato
    {
        public static List<Cliente> LstClientes = new List<Cliente>();

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
        public Cliente(string nome, string cpf, string telefone, string email, string cep)
        {
            Nome = nome;
            Cpf = cpf;
            Telefone = telefone;
            Email = email;
            Cep = cep;
            DataCadastro = DateTime.Now;
        }
        public static bool CadastrarCliente(Cliente cliente)
        {
            LstClientes.Add(cliente);
            return LstClientes.Any();
        }
    }
}
