using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliaApi.Models
{
    public class CursoPost
    {
        public string CodigoInstituicao { get; set; }
        public string CodigoCurso { get; set; }
        public string Nome { get; set; }
        public string Modalidade { get; set; }
    }

    public class CursoResult
    {
        public int Id { get; set; }
        public string CodigoInstituicao { get; set; }
        public string CodigoCurso { get; set; }
        public string Nome { get; set; }
        public string Modalidade { get; set; }
    }
}
