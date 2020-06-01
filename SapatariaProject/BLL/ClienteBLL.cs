using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SapatariaProject.DTO;
using SapatariaProject.DAL;

namespace SapatariaProject.BLL
{
    class ClienteBLL
    {
        ConnectionFactory cF = new ConnectionFactory();
        public void Inserir(ClienteDTO cliente)
        {
            cF.CreateConnection();
            String comando = "Insert INTO Clientes (Nome, Pedidos, Telefone) Values ('" + cliente.Nome + "', 0, '" + cliente.Telefone + "')";
            cF.SqlCommand(comando);
        }
    }
}
