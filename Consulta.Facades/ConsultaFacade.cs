using Consulta.Facades.Interface;
using Consulta.Model;
using Consulta.Services;
using Refit;
using System;
using System.Threading.Tasks;

namespace Consulta.Facades
{
    public class ConsultaFacade: IConsultaFacade
    {
        public async Task<CepResponse> ConsultaCep(string cepInformado)
        {
            var consulta = await new CepApiService().GetAddressASync(cepInformado);

            return consulta;
        }
    }
}
