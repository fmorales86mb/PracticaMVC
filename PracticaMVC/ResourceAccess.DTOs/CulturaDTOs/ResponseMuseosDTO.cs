using System.Collections.Generic;

namespace ResourceAccess.DTOs.CulturaDTOs
{
    public class ResponseMuseosDTO
    {
        public ResponseMuseosDTO()
        {
            this.results = new List<MuseoDTO>();
        }

        public int count { get; set; }
        public string next { get; set; }
        public string previous { get; set; }
        public List<MuseoDTO> results { get; set; }
    }
}
