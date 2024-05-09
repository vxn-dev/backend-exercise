using MISA.NVXUAN.Domain.Order;
using System;

namespace MISA.NVXUAN.Contracts
{
    public interface IOrderService : ICrudBaseService<OrderEntity, OrderDToEditEntity, Guid>
    {
    }
}
