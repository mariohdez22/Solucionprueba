using AutoMapper;
using InformacionCrud.Server.Models;
using InformacionCrud.Shared;

namespace InformacionCrud.Server
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {

            CreateMap<Ciudadano, CiudadanoDTO>().ReverseMap();
            CreateMap<Tiposciudadano, TiposciudadanoDTO>().ReverseMap();
            CreateMap<Nacionalidad, NacionalidadDTO>().ReverseMap();
            CreateMap<Tipodocumento, TipodocumentoDTO>().ReverseMap();
            CreateMap<Biene, BienesDTO>().ReverseMap();

        }
    }
}
