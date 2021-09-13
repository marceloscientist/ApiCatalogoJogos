using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCatalogoJogos_1.Exceptions
{
    public class JogoJaCadastroException : Exception
    {
        public JogoJaCadastroException() : base("Este jogo já esta cadastrado") { }
    }
}
