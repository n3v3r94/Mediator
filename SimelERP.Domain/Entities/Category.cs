using System;
using System.Collections.Generic;
using System.Text;

namespace SimelERP.Domain.Entities
{
    public class Category
    {

        public Category ()
        {
            this.Products = new List<Product>();
        }

        public int CategoryId { get; set; }

        public string Name { get; set; }

        public List<Product> Products {get;set;}
    }
}
