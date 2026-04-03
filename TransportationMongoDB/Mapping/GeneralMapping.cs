using AutoMapper;
using TransportationMongoDB.Dtos.SliderDtos;
using TransportationMongoDB.Entities;

namespace TransportationMongoDB.Mapping
{
    public class GeneralMapping : Profile
    {
        public GeneralMapping()
        {
            CreateMap<Slider, ResultSliderDto>().ReverseMap();
            CreateMap<Slider, CreateSliderDto>().ReverseMap();
            CreateMap<Slider, UpdateSliderDto>().ReverseMap();
            CreateMap<Slider, GetSliderByIdDto>().ReverseMap();
        }
    }
}
