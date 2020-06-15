using API.Dtos;
using AutoMapper;
using Core.Entities;

namespace API.Helpers
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Product, ProductToReturnDto>()
                .ForMember(src => src.ProductBrand, opt => opt.MapFrom(des => des.ProductBrand.Name))
                .ForMember(src => src.ProductType, opt => opt.MapFrom(des => des.ProductType.Name))
                .ForMember(src => src.PictureUrl, opt => opt.MapFrom<ProductUrlResolver>());
        }
    }
}