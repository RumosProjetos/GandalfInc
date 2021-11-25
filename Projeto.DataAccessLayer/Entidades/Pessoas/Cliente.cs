using Projeto.DataAccessLayer.Faturacao;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto.DataAccessLayer.Entidades.Pessoas
{
    public class Cliente : Pessoa
    {
        [Display(Name = "Nome do Cliente")]
        public override string Nome { 
            get => base.Nome;
            set => base.Nome = value; 
        }
        public DateTime DataNascimento { get; set; }

        public virtual List<Venda> Compras { get; set; }
    }
}
