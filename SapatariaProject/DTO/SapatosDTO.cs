using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapatariaProject.DTO
{
    class SapatosDTO
    {
        int id;
        String nome;
        int tamanho;
        int quantidade;
        String sexo;
        float valor;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Tamanho { get => tamanho; set => tamanho = value; }
        public int Quantidade { get => quantidade; set => quantidade = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public float Valor { get => valor; set => valor = value; }
    }
}
