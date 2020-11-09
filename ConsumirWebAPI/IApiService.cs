using Refit;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsumirWebAPI
{
   public interface IApiService
    {
        //Interface teste obtendo todos os UF:MG.
        [Get("/Services/CategoriaOficialService.svc/ObterPorEstadoFazenda/2")]
        Task<ApiResponse> GetAddressAsync(string UF);

        //Mêtodos convencionais operações REST usando refit.

        [Post("/apiresponde")]
        Task<ApiResponse> InsertAsync([Body] ApiResponse apiresponde);

        [Put("/apiresponde")]
        Task<ApiResponse> UpdateAsync([Body] ApiResponse apiresponde);

        [Get("/apiresponde")]
        Task<IList<ApiResponse>> GetAsync();

        [Get("/apiresponde/{id}")]
        Task<ApiResponse> GetAsync(int id);

        [Delete("/apiresponde/{id}")]
        Task DeleteAsync(int id);
    }
}
