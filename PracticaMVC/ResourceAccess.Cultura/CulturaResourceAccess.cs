using AutoMapper;
using Entities.Cultura;
using ResourceAccess.DTOs.CulturaDTOs;
using ResourceAccess.Interfaces;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace ResourceAccess.Cultura
{
    public class CulturaResourceAccess : ICulturaResourceAccess
    {
        #region Atributtes

        private HttpClient client;
        private IMapper mapper;
        const string urlBase = "https://www.cultura.gob.ar/api/v2.0/";

        #endregion

        #region Constructor

        public CulturaResourceAccess()
        {
            this.InicializarClient();
            this.mapper = MappingConfig.RegisterComponents().CreateMapper();
        }

        #endregion

        #region Public Methods

        public async Task<List<MuseoEntity>> GetMuseosAsync()
        {
            ResponseMuseosDTO data;
            List<MuseoEntity> museos = new List<MuseoEntity>();
            string uri = "museos";

            try
            {
                HttpResponseMessage response = await client.GetAsync(uri);

                if (response.IsSuccessStatusCode)
                {
                    // Para GetAsAsync se debe instalar Microsoft.AspNet.WebApi.Client
                    data = await response.Content.ReadAsAsync<ResponseMuseosDTO>();
                    museos = this.mapper.Map<List<MuseoEntity>>(data.results);
                }
            }
            catch (Exception)
            {

                throw;
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
