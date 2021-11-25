﻿namespace Projeto.DataAccessLayer.Entidades.Pessoas
{
    public abstract class Pessoa : Entidade
    {
        public string NumeroFiscal { get; set; }
        public Morada Morada { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        protected Pessoa()
        {
            Morada = new Morada();
        }
    }
}