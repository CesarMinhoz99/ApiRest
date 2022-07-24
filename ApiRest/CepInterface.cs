using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiRest
{
    internal interface CepInterface 
    {
        [Get("/ws/{cep}/json")]
        Task<CepModel> GetAddressAsync (string cep);
    }
}
