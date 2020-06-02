using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaProject.DTO
{
    public class VendedoresDTO
    {
        String login;
        String senha;
        int vendas;

        public string Login { get => login; set => login = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Vendas { get => vendas; set => vendas = value; }
    }
}
