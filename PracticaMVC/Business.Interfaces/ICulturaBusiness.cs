using Entities.Cultura;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ICulturaBusiness
    {
        Task<List<MuseoEntity>> GetMuseosAsync();
    }
}
