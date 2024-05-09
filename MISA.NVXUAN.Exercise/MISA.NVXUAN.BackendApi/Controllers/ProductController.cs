using Microsoft.AspNetCore.Mvc;
using MISA.NVXUAN.Contracts;
using MISA.NVXUAN.Domain.Product;
using System;

namespace MISA.NVXUAN.BackendApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : CrudBaseController<IProductService, ProductEntity, ProductDToEditEntity, Guid>
    {
        public ProductController(IProductService service) : base(service) { }
    }
}
