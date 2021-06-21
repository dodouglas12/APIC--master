using Consulta.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Consulta.Facades.Interface
{
    public interface IConsultaFacade
    {
        Task<CepResponse> ConsultaCep(string cepInformado);
    }
}
