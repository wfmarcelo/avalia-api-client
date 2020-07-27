using AvaliaApi.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliaApi.Services
{
    public interface IAvaliaService<TPost, TResult>
    {
        Task DeleteAsync(int id);
        Task<List<TResult>> GetAsync();
        Task<TResult> PostAsync(TPost model);
        Task<TResult> PutAsync(int id, TPost model);
    }
}