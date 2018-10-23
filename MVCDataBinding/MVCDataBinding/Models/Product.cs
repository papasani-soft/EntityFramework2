using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MVCDataBinding.Models
{
    [Table("tblProducts")]
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> Price { get; set; }

    }
}