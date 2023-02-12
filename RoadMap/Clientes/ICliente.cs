using RoadMap.Clientes.Model;
using RoadMap.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMap.Clientes
{
    public interface ICliente
    {
        public void CadastrarCliente();

       // void GetNome(string nome);
        //void GetCpf(string cpf);
        //void GetAllClientes();
        void EditarCliente(string nome);
        void DeletarCliente();

    }
}
