using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.NVXUAN.Domain.Order
{
    public class OrderEntity
    {
        [DomainShared.Attributes.Key]
        public Guid order_id { get; set; }
        public string order_code { get; set; }
        public Guid customer_id { get; set; }
        public DateTime order_time { get; set; }
        public double? sum_amount { get; set; }
    }
}
