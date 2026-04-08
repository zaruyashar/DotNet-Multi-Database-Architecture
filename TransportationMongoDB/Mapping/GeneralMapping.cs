using AutoMapper;
using TransportationMongoDB.Dtos.BrandDtos;
using TransportationMongoDB.Dtos.OfferDtos;
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

            CreateMap<Brand, ResultBrandDto>().ReverseMap();
            CreateMap<Brand, CreateBrandDto>().ReverseMap();
            CreateMap<Brand, UpdateBrandDto>().ReverseMap();
            CreateMap<Brand, GetBrandByIdDto>().ReverseMap();

            CreateMap<Offer, ResultOfferDto>().ReverseMap();
            CreateMap<Offer, CreateOfferDto>().ReverseMap();
            CreateMap<Offer, UpdateOfferDto>().ReverseMap();
            CreateMap<Offer, GetOfferByIdDto>().ReverseMap();
        }
    }
}
