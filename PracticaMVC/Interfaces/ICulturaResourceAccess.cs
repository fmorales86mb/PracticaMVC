using DTOs.CulturaDTOs;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ICulturaServices
    {
        Task<List<MuseoDTO>> GetMuseosAsync();
    }
}
