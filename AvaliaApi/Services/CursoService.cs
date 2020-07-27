using AvaliaApi.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AvaliaApi.Services
{
    public class CursoService : AvaliaService, IAvaliaService<CursoPost, CursoResult>
    {
        public CursoService(AvaliaApiClient avaliaApiClient) : base("api/Curso", avaliaApiClient)
        {
        }

        public async Task DeleteAsync(int id)
        {
            await _api.GetAsync<CursoResult>($"{_url}/{id}");
        }

        public async Task<CursoResult> GetAsync(string codigoInstituicao, string codigoCurso)
        {
            return await _api.GetAsync<CursoResult>($"{_url}/{codigoInstituicao}/{codigoCurso}");
        }

        public async Task<List<CursoResult>> GetAsync()
        {
            return await _api.GetAsync<List<CursoResult>>(_url);
        }

        public Task<CursoResult> PostAsync(CursoPost model)
        {
            throw new NotImplementedException();
        }

        public Task<CursoResult> PutAsync(int id, CursoPost model)
        {
            throw new NotImplementedException();
        }
    }
}
