
namespace SimelERP.Application.Product.Queris.GetAllProduct
{
    using AutoMapper;
    using MediatR;
    using Microsoft.EntityFrameworkCore;
    using SimelERP.Persistence;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Threading.Tasks;


    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ProductListViewModel>
    {
        private readonly SimelERPDbContext context;
        private readonly IMapper mapper;

        public GetAllProductsQueryHandler(SimelERPDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<ProductListViewModel> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var products = await context.Products.OrderBy(p => p.Name).ToListAsync(cancellationToken);

            var model = new ProductListViewModel
            {
                Products = mapper.Map<IEnumerable<ProductDto>>(products),
                CreateEnabled = true
            };

            return model;
        }
    }
}
