using System;
using System.Collections.Generic;
using System.Text;

namespace AvaliaApi.Services
{
    public class AvaliaService
    {
        protected readonly AvaliaApiClient _api;
        protected readonly string _url;

        public AvaliaService(string url, AvaliaApiClient avaliaApiClient)
        {
            _url = url;
            _api = avaliaApiClient;
        }

    }
}
