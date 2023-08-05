using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeSOLID.ISP.Solucao
{
    public interface ICadastroProduto
    {
        void ValidarDados();
        void SalvarBanco();
    }
}