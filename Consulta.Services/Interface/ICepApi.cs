using Consulta.Model;
using Refit;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consulta.Services.Interface
{
    public interface ICepApi
    {
        [Get("/ws/{cep}/json")]
        Task<CepResponse> GetAddressASync(string cep);
    }
}
