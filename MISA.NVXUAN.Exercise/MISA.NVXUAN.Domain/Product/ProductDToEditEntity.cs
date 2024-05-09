using MISA.NVXUAN.DomainShared.Attributes;
using System;

namespace MISA.NVXUAN.Domain.Product
{
    public class ProductDToEditEntity : ProductEntity, IRecordState
    {
        public int? state { get; set; }
    }
}
