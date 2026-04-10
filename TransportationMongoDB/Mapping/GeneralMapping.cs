using AutoMapper;
using TransportationMongoDB.Dtos.ShipmentTrackingDtos;
using TransportationMongoDB.Entities;
using TransportationMongoDB.Dtos.AboutDtos;
using TransportationMongoDB.Dtos.BrandDtos;
using TransportationMongoDB.Dtos.GetInTouchDtos;
using TransportationMongoDB.Dtos.HowItWorkDtos;
using TransportationMongoDB.Dtos.OfferDtos;
using TransportationMongoDB.Dtos.ProjectSectionDtos;
using TransportationMongoDB.Dtos.QuestionDtos;
using TransportationMongoDB.Dtos.ShipmentDtos;
using TransportationMongoDB.Dtos.SliderDtos;
using TransportationMongoDB.Dtos.TestimonialDtos;
using TransportationMongoDB.Entities;
using DatabaseMastery.TransportMongoDb.Entities;

namespace DatabaseMastery.TransportMongoDb.Mapping
{
    public class GeneralMapping:Profile
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

            CreateMap<About, ResultAboutDto>().ReverseMap();
            CreateMap<About, CreateAboutDto>().ReverseMap();
            CreateMap<About, UpdateAboutDto>().ReverseMap();
            CreateMap<About, GetAboutByIdDto>().ReverseMap();

            CreateMap<GetInTouch, ResultGetInTouchDto>().ReverseMap();
            CreateMap<GetInTouch, UpdateGetInTouchDto>().ReverseMap();
            CreateMap<GetInTouch, CreateGetInTouchDto>().ReverseMap();
            CreateMap<GetInTouch, GetInTouchByIdDto>().ReverseMap();

            CreateMap<HowItWork, ResultHowItWorkDto>().ReverseMap();
            CreateMap<HowItWork, CreateHowItWorkDto>().ReverseMap();
            CreateMap<HowItWork, UpdateHowItWorkDto>().ReverseMap();
            CreateMap<HowItWork, GetHowItWorkByIdDto>().ReverseMap();

            CreateMap<Testimonial, ResultTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, CreateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, UpdateTestimonialDto>().ReverseMap();
            CreateMap<Testimonial, GetTestimonialByIdDto>().ReverseMap();

            CreateMap<ProjectSection, ResultProjectSectionDto>().ReverseMap();
            CreateMap<ProjectSection, UpdateProjectSectionDto>().ReverseMap();
            CreateMap<ProjectSection, CreateProjectSectionDto>().ReverseMap();
            CreateMap<ProjectSection, GetProjectSectionByIdDto>().ReverseMap();

            CreateMap<Question, ResultQuestionDto>().ReverseMap();
            CreateMap<Question, UpdateQuestionDto>().ReverseMap();
            CreateMap<Question, GetQuestionByIdDto>().ReverseMap();
            CreateMap<Question, CreateQuestionDto>().ReverseMap();

            CreateMap<Shipment, ResultShipmentDto>().ReverseMap();
            CreateMap<Shipment, CreateShipmentDto>().ReverseMap();
            CreateMap<Shipment, UpdateShipmentDto>().ReverseMap();
            CreateMap<Shipment, GetShipmentByIdDto>().ReverseMap();

            CreateMap<ShipmentTracking, CreateShipmentTrackingDto>().ReverseMap();
            CreateMap<ShipmentTracking, ResultShipmentTrackingDto>().ReverseMap();
            CreateMap<ShipmentTracking, UpdateShipmentTrackingDto>().ReverseMap();
        }
    }
}
