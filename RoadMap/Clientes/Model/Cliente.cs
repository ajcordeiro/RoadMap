using System;
using System.Collections.Generic;

namespace RoadMap.Clientes.Model
{
    public class Cliente : Contato
    {
        public static List<Cliente> ListaClientes = new List<Cliente>();

        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }
        public DateTime DataAlteracao { get; set; }

    }
}
