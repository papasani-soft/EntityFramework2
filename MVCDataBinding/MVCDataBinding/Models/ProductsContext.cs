using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MVCDataBinding.Models
{
    public class ProductsContext :DbContext
    {
        public ProductsContext()
            :base("ProductsConnection")
        {
        }
        public DbSet<Product> ProductsTable { get; set; }

    }
}