using MISA.NVXUAN.DomainShared.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.NVXUAN.Domain.Product
{
    public class ProductCategoryEntity
    {
        [Key]
        public Guid product_category_id { get; set; }
        public string product_category_code { get; set; }
        public string product_category_name { get; set; }
        public string description { get; set; }
    }
}
