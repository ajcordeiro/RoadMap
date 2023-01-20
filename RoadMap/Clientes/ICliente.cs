using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoadMap.Clientes
{
    public interface ICliente
    {
        void CadastrarCliente();
        void BuscarPorNome(string nome);
        void BuscarTodosOsClientes();
        void EditarCliente(string nome);
        void DeletarCliente(string nome);
    }
}
