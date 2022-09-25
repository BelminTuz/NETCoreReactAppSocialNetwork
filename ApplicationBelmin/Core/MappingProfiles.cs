using AutoMapper;
using Domain;

namespace ApplicationBelmin.Core
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Activity, Activity>();
        }
    }
}