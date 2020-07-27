using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliaApi.Models
{
    public class AlunoPost
    {
        public string CodigoInstituicao { get; set; }
        public string CPF { get; set; }
        public string Nome { get; set; }
        public string NomeSocial { get; set; }
        public string RA { get; set; }
        public string CodigoUsuario { get; set; }
        public string Email { get; set; }
    }

    public class AlunoResult
    {
        public int Id { get; set; }
        public long CPF { get; set; }
        public string Nome { get; set; }
        public string RA { get; set; }
        public string CodigoUsuario { get; set; }
        public string Email { get; set; }
    }

}
