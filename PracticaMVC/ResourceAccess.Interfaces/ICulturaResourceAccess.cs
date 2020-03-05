using ResourceAccess.DTOs.CulturaDTOs;
using System.Threading.Tasks;

namespace ResourceAccess.Interfaces
{
    public interface ICulturaResourceAccess
    {
        Task<ResponseMuseosDTO> GetMuseosAsync();
    }
}
