using System;

namespace MISA.NVXUAN.Domain.Customer
{
    public class CustomerDToEditEntity : CustomerEntity, IRecordState
    {
        public int? state { get; set; }
    }
}
