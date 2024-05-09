using MISA.NVXUAN.Domain.Order;
using MISA.NVXUAN.Domain.Product;
using System;

namespace MISA.NVXUAN.Contracts
{
    public interface IProductService : ICrudBaseService<ProductEntity, ProductDToEditEntity, Guid>
    {
    }
}
