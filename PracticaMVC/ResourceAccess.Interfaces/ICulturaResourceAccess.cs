using ResourceAccess.DTOs.CulturaDTOs;
using System.Threading.Tasks;

namespace ResourceAccess.Interfaces
{
    public interface ICulturaServices
    {
        Task<ResponseMuseosDTO> GetMuseosAsync();
    }
}
