using MISA.NVXUAN.Contracts;
using MISA.NVXUAN.Domain.Customer;
using MISA.NVXUAN.Domain.Order;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.NVXUAN.Application
{
    public class OrderService : CrudBaseService<OrderEntity, OrderDToEditEntity, Guid>, IOrderService
    {
        public OrderService(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
