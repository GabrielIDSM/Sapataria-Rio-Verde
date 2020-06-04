using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaProject.DTO
{
    class VendasDTO
    {
        int id;
        String vendedor;
        int cliente;
        float valor;
        int dia;
        int mes;
        int ano;

        public int Id { get => id; set => id = value; }
        public string Vendedor { get => vendedor; set => vendedor = value; }
        public int Cliente { get => cliente; set => cliente = value; }
        public float Valor { get => valor; set => valor = value; }
        public int Dia { get => dia; set => dia = value; }
        public int Mes { get => mes; set => mes = value; }
        public int Ano { get => ano; set => ano = value; }
    }
}
