using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsumirWebAPI
{
    class Program
    {
        static async System.Threading.Tasks.Task Main(string[] args)
        {

            //Teste exibindo no console todos os dados com o UF: MG
            var ufClient = RestService.For<IApiService>("http://tst.sportibrasil.com.br/");
            string meuUF = "MG";
            Console.WriteLine("Consultando dados do UF:" + meuUF);

            ApiResponse address = await ufClient.GetAddressAsync(meuUF);

            Console.Write($"\nID:{address.ID}\nNome:{address.Nome}\nSexo:{address.Sexo}" +
                $"\nUF:{address.UF}\nValorMaximo:{address.ValorMaximo}\nValorMinimo:{address.ValorMinimo}");
            _ = Console.ReadKey();

        }

        private readonly IApiService _Program;
        private readonly string _apiUrl;

        public Program()

        {
            _apiUrl = "http://tst.sportibrasil.com.br/Services/CategoriaOficialService.svc/ObterPorEstadoFazenda/2";
            _Program = RestService.For<IApiService>(_apiUrl);
        }

        public async Task DeleteAsync(int id)
        {
            await _Program.DeleteAsync(id);
        }

        public async Task<IList<ApiResponse>> GetAsync()
        {
            return await _Program.GetAsync();
        }

        public async Task<ApiResponse> GetAsync(int id)
        {
            return await _Program.GetAsync(id);
        }

        public async Task<ApiResponse> InsertAsync(ApiResponse apiresponse)
        {
            return await _Program.InsertAsync(apiresponse);
        }

        public async Task<ApiResponse> UpdateAsync(ApiResponse apiresponse)
        {
            return await _Program.UpdateAsync(apiresponse);
        }
    }
}
