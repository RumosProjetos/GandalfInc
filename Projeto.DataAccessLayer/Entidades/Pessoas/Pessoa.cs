using System.ComponentModel.DataAnnotations;

namespace Projeto.DataAccessLayer.Entidades.Pessoas
{
    public abstract class Pessoa : Entidade
    {
        [Required, MaxLength(9, ErrorMessage = "NIF com tamanho errado"), MinLength(9, ErrorMessage = "NIF com tamanho errado")]
        public string NumeroFiscal { get; set; }
        public Morada Morada { get; set; }
        public string Telefone { get; set; }

        [EmailAddress, MaxLength(255)]
        public string Email { get; set; }

        protected Pessoa()
        {
            Morada = new Morada();
        }
    }
}