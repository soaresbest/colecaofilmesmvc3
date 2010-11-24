using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ColecaoFilmes.Infraestrutura.AcessoDados
{
    public interface IDAHelper
    {
        void Salvar(object entidade);
        void Alterar(object entidade);
        
    }
}
