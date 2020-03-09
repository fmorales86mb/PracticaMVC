using Entities.Cultura;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ResourceAccess.Interfaces
{
    public interface ICulturaResourceAccess
    {
        Task<List<MuseoEntity>> GetMuseosAsync();
    }
}
