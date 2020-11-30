using AutoMapper;
using CRCompras.Controllers.Resources;
using CRCompras.Models;

namespace CRCompras.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Make,MakeResource>();
            CreateMap<Model_car, ModelResource>();
            CreateMap<Feature, FeatureResource>();
        }
    }
}