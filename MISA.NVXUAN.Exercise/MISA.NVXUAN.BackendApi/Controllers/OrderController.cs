using Microsoft.AspNetCore.Mvc;
using MISA.NVXUAN.Contracts;
using MISA.NVXUAN.Domain.Order;
using System;

namespace MISA.NVXUAN.BackendApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : CrudBaseController<IOrderService, OrderEntity, OrderDToEditEntity, Guid>
    {
        public OrderController(IOrderService service) : base(service)
        {
        }
    }
}
