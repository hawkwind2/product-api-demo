using AutoMapper;
using Product_Kolmeo.Entities;

namespace Product_Kolmeo.Models
{
    public class SourceMappingProfile: Profile
    {
        public SourceMappingProfile()
        {
            CreateMap<Product, ProductModel>();

            CreateMap<ProductModel, Product>();
        }
    }
}
