using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.NVXUAN.Domain.Order
{
    public class OrderDToEditEntity : OrderEntity, IRecordState
    {
        public int? state { get; set; }
    }
}
