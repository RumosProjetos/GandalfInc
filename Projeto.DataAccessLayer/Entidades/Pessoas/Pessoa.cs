using System.ComponentModel.DataAnnotations;

namespace Projeto.DataAccessLayer.Entidades.Pessoas
{
    public abstract class Pessoa : Entidade
    {
        [Required, MaxLength(9, ErrorMessage = "NIF com tamanho errado"), MinLength(9, ErrorMessage = "NIF com tamanho errado")]
        public string NumeroFiscal { get; set; }
        
        public string Telefone { get; set; }

        [EmailAddress, MaxLength(255)]
        public string Email { get; set; }



        public string Endereco { get; set; } //rua das casas    n 25
        public string CodigoPostal { get; set; } //2830
        public string Localidade { get; set; } //barreiro
        public string Complemento { get; set; } //Falar com a vizinha da frente 

    }
}