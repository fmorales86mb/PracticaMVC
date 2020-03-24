using Entities.Cultura;
using Business.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using ResourceAccess.Interfaces;
using System;

namespace Business.Cutura
{
    /// <summary>
    /// 
    /// </summary>
    public class CulturaBusiness : ICulturaBusiness
    {
        #region Atributtes

        private ICulturaResourceAccess culturaResourceAccess;                

        #endregion

        #region Constructor

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="culturaResourceAccess"></param>
        public CulturaBusiness(ICulturaResourceAccess culturaResourceAccess)
        {
            this.culturaResourceAccess = culturaResourceAccess;            
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Trae la lista de museos.
        /// </summary>
        /// <returns></returns>
        public async Task<List<MuseoEntity>> GetMuseosAsync()
        {
            List<MuseoEntity> museos;
            
            try
            {
                var response = await this.culturaResourceAccess.GetMuseosAsync();
                museos = response != null ? response : new List<MuseoEntity>();
            }
            catch (Exception)
            {

                throw;
            }            

            return museos;
        }

        #endregion

        #region Private Methods



        #endregion
    }
}
