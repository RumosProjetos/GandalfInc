using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Lib.Entidades
{
    public class Fornecedor : Pessoa
    {
        public int Pontuacao { get; set; } //Classificacao
        public bool Ativo { get; set; }
    }
}
