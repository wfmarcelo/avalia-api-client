using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliaApi.Models
{
    public class CoordenadorCursoPost
    {
        public string CodigoInstituicao { get; set; }
        public string CodigoCurso { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public string CodigoUsuario { get; set; }
        public string email { get; set; }
    }

    public class CoordenadorCursoResult
    {
        public int IdCoordenador { get; set; }
        public long CPF { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public string CodigoUsuario { get; set; }
        public string email { get; set; }
        public List<CursoResult> cursos { get; set; }
    }
}
