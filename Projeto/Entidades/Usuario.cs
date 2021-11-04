using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto.Lib.Entidades
{
    //Usuario ou Utilizador
    public class Usuario : Entidade
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
