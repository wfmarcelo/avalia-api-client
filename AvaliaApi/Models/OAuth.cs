using System;

namespace AvaliaApi.Models
{
    public class OAuth
    {
        public string CodigoInstituicao { get; set; }
        public string Senha { get; set; }
    }

    public class OAuthResult
    {
        public string Token { get; set; }
        public int Expires { get; set; }
        public bool Succeeded { get; set; }
    }
}
