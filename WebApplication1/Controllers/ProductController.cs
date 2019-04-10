using Microsoft.AspNetCore.Mvc;
using SimelERP.Application.Product.Queris.GetAllProduct;
using System.Threading.Tasks;

namespace SimelERP.Web.Controllers
{
    public class ProductController : BaseController
    {
        [HttpGet]
        public async Task<ActionResult<ProductListViewModel>> GetAll()
        {
            return Ok(await Mediator.Send(new GetAllProductsQuery()));
        }
    }
}
