using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mercadinho
{
    internal class Produto
    {
        public string Codigo;
        public string Descricao;
        public float Preco;
        public float Qntestoque;
        public string Coisa;

        public Produto(string codigo, string descricao, float preco, float qntestoque, string coisa)
        {
            Codigo = codigo;
            Descricao = descricao;
            Preco = preco;
            Qntestoque = qntestoque;
            Coisa = coisa;
        }
    }
}
