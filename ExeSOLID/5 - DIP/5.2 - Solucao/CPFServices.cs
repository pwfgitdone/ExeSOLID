using ExeSOLID.DIP.Solucao.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeSOLID.DIP.Solucao
{
    public class CPFServices : ICPFServices
    {
        public bool IsValid(string cpf)
        {
            return cpf.Length == 11;
        }
    }
}
