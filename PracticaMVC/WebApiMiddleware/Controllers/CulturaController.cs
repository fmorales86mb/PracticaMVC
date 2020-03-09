using Business.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

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
        public async Task GetMuseosAsync()
        {
            var prueba = await this.culturaBusiness.GetMuseosAsync();
        }

        #endregion

        #region
        #endregion
    }
}
