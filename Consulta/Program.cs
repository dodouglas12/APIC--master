using Refit;
using System;
using System.Threading.Tasks;
using Consulta.Facades;

namespace Consulta
{
    class Program
    {
        static async Task Main(string[] args)
        {
            try 
            {
                Console.WriteLine("Informe seu CEP:");
                string CepInformado = Console.ReadLine().ToString();

                var Consulta = await new ConsultaFacade().ConsultaCep(CepInformado);

                Console.WriteLine($"\n Endereço:{Consulta.Logradouro} \n Complemento: {Consulta.Complemento} \n Bairro:{Consulta.Bairro} " +
                    $"\n Cidade:{Consulta.Localidade} \n Estado: {Consulta.UF}");
                Console.ReadKey();
            } catch
            {
                Console.WriteLine("Erro na consulta do CEP!");
            }
        }
    }
}
