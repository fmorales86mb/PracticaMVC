using DTOs.CulturaDTOs;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace CulturaResourceAccess
{
    public class CulturaServices : ICulturaServices
    {
        #region Atributtes

        private HttpClient client;
        const string urlBase = "https://www.cultura.gob.ar/api/v2.0/";

        #endregion

        #region Constructor

        public CulturaResourceAccess()
        {
            this.client = new HttpClient()
            {
                BaseAddress = new Uri(urlBase)
            };
        }

        #endregion

        #region Public Methods

        public async Task<List<MuseoDTO>> GetMuseosAsync()
        {
            List<MuseoDTO> museos = new List<MuseoDTO>();
            string uri = "museos";

            var respons = await this.client.GetAsync(uri);

            return museos;
        }

        #endregion

        #region Private Methods
        #endregion
    }
}
