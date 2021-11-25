using Projeto.DataAccessLayer.Utils;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projeto.DataAccessLayer.Entidades
{
    public abstract class Entidade
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Identificador { get; set; }


        private string nome;
        [Required, MaxLength(255)]
        public virtual string Nome
        {
            get { return nome; }
            set {
                //nome = value.ToUpper(); 
                //nome = StringUtils.ToTitleCase(value);
                nome = value.ToTitleCase();
            }
        }



        public DateTime? DataCriacao { get; set; } //TODO: JNETO - tirar o nulable / configurar trigger
        public DateTime? DataAlteracao { get; set; }
        public bool Ativo { get; set; } = true;
    }
}