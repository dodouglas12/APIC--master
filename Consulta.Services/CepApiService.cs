using Consulta.Model;
using Consulta.Services.Interface;
using Refit;
using System;
using System.Threading.Tasks;

namespace Consulta.Services
{
    public class CepApiService : ICepApi
    {
        private const string URL_CONSULTA_CEP = "https://viacep.com.br/";

        public async Task<CepResponse> GetAddressASync(string cep)
        {
            var service = RestService.For<ICepApi>(URL_CONSULTA_CEP);
            return await service.GetAddressASync(cep);
        }
    }
}
