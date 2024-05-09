using MISA.NVXUAN.Contracts;
using MISA.NVXUAN.Domain.Product;
using System;

namespace MISA.NVXUAN.Application
{
    public class ProductService : CrudBaseService<ProductEntity, ProductDToEditEntity, Guid>, IProductService
    {
        public ProductService(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
