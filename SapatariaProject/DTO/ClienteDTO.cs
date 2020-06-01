using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaProject.DTO
{
    class ClienteDTO
    {
        int id;
        String nome;
        int compras;
        String telefone;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Compras { get => compras; set => compras = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
