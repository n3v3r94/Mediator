
namespace SimelERP.Application.Product.Queris.GetAllProduct
{
    using AutoMapper;
    using SimelERP.Application.Interfaces.Mapping;
    using SimelERP.Domain.Entities;

    public class ProductDto : IHaveCustomMapping
    {

        public int ProductId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public double Price { get; set; }


        public void CreateMappings(Profile configuration)
        {
            configuration.CreateMap<Product, ProductDto>();
                
        }
    }
}
