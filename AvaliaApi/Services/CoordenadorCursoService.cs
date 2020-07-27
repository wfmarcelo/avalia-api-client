using AvaliaApi.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AvaliaApi.Services
{
    public class CoordenadorCursoService : AvaliaService, IAvaliaService<CoordenadorCursoPost, CoordenadorCursoResult>
    {
        public CoordenadorCursoService(AvaliaApiClient avaliaApiClient) 
            : base("api/CoordenadorCurso", avaliaApiClient)
        {
            
        }

        public async Task DeleteAsync(int id)
        {
            await _api.GetAsync<CoordenadorCursoResult>($"{_url}/{id}");
        }

        public async Task<CoordenadorCursoResult> GetAsync(string cpf)
        {
            return await _api.GetAsync<CoordenadorCursoResult>($"{_url}/{cpf}");
        }

        public async Task<CoordenadorCursoResult> PostAsync(CoordenadorCursoPost model)
        {
            return await _api.PostAsync<CoordenadorCursoResult, CoordenadorCursoPost>(_url, model);
        }

        public async Task<CoordenadorCursoResult> PutAsync(int id, CoordenadorCursoPost model)
        {
            return await _api.PutAsync<CoordenadorCursoResult, CoordenadorCursoPost>($"{_url}/{id}", model);
        }

        public async Task<List<CoordenadorCursoResult>> GetAsync()
        {
            return await _api.GetAsync<List<CoordenadorCursoResult>>(_url);
        }
    }
}
