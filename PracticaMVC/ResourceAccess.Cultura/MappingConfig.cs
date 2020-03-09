using AutoMapper;
using Entities.Cultura;
using ResourceAccess.DTOs.CulturaDTOs;

namespace ResourceAccess.Cultura
{
    public static class MappingConfig
    {
        /// <summary>
        /// Contiene los mapeos.
        /// </summary>
        /// <returns></returns>
        public static MapperConfiguration RegisterComponents()
        {
            var configuration = new MapperConfiguration
            (
                cfg =>
                {
                    SetMuseoDTOToEntityMapper(cfg);
                }
            );

            return configuration;
        }

        /// <summary>
        /// Configuro el mapeo particular
        /// </summary>
        /// <param name="cfg"></param>
        private static void SetMuseoDTOToEntityMapper(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<MuseoDTO, MuseoEntity>()
                .ForMember(e => e.Id, opt => opt.MapFrom(d => d.id))
                .ForMember(e => e.Autoridad, opt => opt.MapFrom(d => d.autoridad))
                .ForMember(e => e.DependeDe, opt => opt.MapFrom(d => d.depende_De))
                .ForMember(e => e.Descripcion, opt => opt.MapFrom(d => d.descripcion))
                .ForMember(e => e.Direccion, opt => opt.MapFrom(d => d.direccion))
                .ForMember(e => e.Email, opt => opt.MapFrom(d => d.email))
                .ForMember(e => e.Link, opt => opt.MapFrom(d => d.link))
                .ForMember(e => e.Nombre, opt => opt.MapFrom(d => d.nombre))
                .ForMember(e => e.Provincia, opt => opt.MapFrom(d => d.provincia)) 
                .ForMember(e => e.Telefono, opt => opt.MapFrom(d => d.telefono))
                .ForMember(e => e.Url, opt => opt.MapFrom(d => d.url));
        }
    }
}
