using Business.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;
using Entities.Cultura;

namespace WebApiMiddleware.Controllers
{
    public class CulturaController : ApiController
    {
        #region Atributtes

        private ICulturaBusiness culturaBusiness;

        #endregion

        #region Constructor

        public CulturaController(ICulturaBusiness culturaBusiness)
        {
            this.culturaBusiness = culturaBusiness;
        }

        #endregion

        #region
        
        [HttpGet]
        [Route("api/getmuseos")]
        public async Task<List<MuseoEntity>> GetMuseosAsync()
        {
            var museos = await this.culturaBusiness.GetMuseosAsync();
            return museos;
        }

        #endregion

        #region
        #endregion
    }
}
