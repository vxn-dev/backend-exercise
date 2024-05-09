using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.NVXUAN.Domain.Order
{
    public class OrderDetailEntity
    {
        [DomainShared.Attributes.Key]
        public Guid order_detail_id { get; set; }
        public Guid order_id { get; set; }
        public Guid product_id { get; set; }
        public int quantity { get; set; }
        public double? price { get; set; }
    }
}
