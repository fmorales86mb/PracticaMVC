using ResourceAccess.DTOs.CulturaDTOs;
using ResourceAccess.Interfaces;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ResourceAccess.Cultura
{
    public class CulturaServices : ICulturaServices
    {
        #region Atributtes

        private HttpClient client;
        const string urlBase = "https://www.cultura.gob.ar/api/v2.0/";

        #endregion

        #region Constructor

        public CulturaServices()
        {
            this.InicializarClient();
        }

        #endregion

        #region Public Methods

        public async Task<ResponseMuseosDTO> GetMuseosAsync()
        {
            ResponseMuseosDTO museos = new ResponseMuseosDTO();
            string uri = "museos";
            
            HttpResponseMessage response = await client.GetAsync(uri);

            if (response.IsSuccessStatusCode)
            {
                // Para GetAsAsync se debe instalar Microsoft.AspNet.WebApi.Client
                museos = await response.Content.ReadAsAsync<ResponseMuseosDTO>();
            }                        

            return museos;
        }

        #endregion

        #region Private Methods

        private void InicializarClient()
        {
            MediaTypeWithQualityHeaderValue contentType = new MediaTypeWithQualityHeaderValue("application/json");
            contentType.CharSet = "UTF-8";

            this.client = new HttpClient()
            {
                BaseAddress = new Uri(urlBase),
            };

            client.DefaultRequestHeaders.Accept.Add(contentType);
        }

        #endregion
    }
}
