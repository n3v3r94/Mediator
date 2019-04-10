using System;
using System.Collections.Generic;
using System.Text;

namespace SimelERP.Application.Product.Queris.GetAllProduct
{
   public class ProductListViewModel
    {
        public IEnumerable<ProductDto> Products { get; set; }

        public bool CreateEnabled { get; set; }
    }
}
