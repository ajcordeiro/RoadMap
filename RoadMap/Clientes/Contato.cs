using RoadMap.Clientes.Model;

namespace RoadMap.Clientes
{
    public abstract class Contato
    {
        public string Telefone { get; set; }
        public string Endereco { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public string Email { get; set; }
        public Cliente cliente { get; set; }
    }
}
