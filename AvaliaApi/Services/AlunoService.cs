using AvaliaApi.Models;
using AvaliaApi.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliaApi.Data
{
    public class AlunoService : AvaliaService, IAvaliaService<AlunoPost, AlunoResult>
    {
        public AlunoService(AvaliaApiClient avaliaApiClient) : base("api/Aluno", avaliaApiClient)
        {
        }

        public async Task<AlunoResult> GetAsync(string cpf)
        {
            return await _api.GetAsync<AlunoResult>($"{_url}/{cpf}");
        }

        public async Task<AlunoResult> PostAsync(AlunoPost model)
        {
            return await _api.PostAsync<AlunoResult, AlunoPost>(_url, model);
        }

        public async Task<AlunoResult> PutAsync(int id, AlunoPost model)
        {
            return await _api.PutAsync<AlunoResult, AlunoPost>($"{_url}/{id}", model);
        }

        public async Task DeleteAsync(int id)
        {
            await _api.DeleteAsync($"{_url}/{id}");
        }

        public Task<List<AlunoResult>> GetAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
