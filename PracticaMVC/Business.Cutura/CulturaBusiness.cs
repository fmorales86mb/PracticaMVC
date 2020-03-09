using Entities.Cultura;
using Business.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using ResourceAccess.Interfaces;

namespace Business.Cutura
{
    public class CulturaBusiness : ICulturaBusiness
    {
        #region Atributtes

        private ICulturaResourceAccess culturaResourceAccess;                

        #endregion

        #region Constructor

        public CulturaBusiness(ICulturaResourceAccess culturaResourceAccess)
        {
            this.culturaResourceAccess = culturaResourceAccess;            
        }

        #endregion

        #region Public Methods

        public async Task<List<MuseoEntity>> GetMuseosAsync()
        {
            var museos = await this.culturaResourceAccess.GetMuseosAsync();

            return museos;
        }

        #endregion

        #region Private Methods



        #endregion
    }
}
