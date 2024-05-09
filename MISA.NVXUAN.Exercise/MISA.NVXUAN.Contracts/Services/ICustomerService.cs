using MISA.NVXUAN.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.NVXUAN.Contracts
{
    public interface ICustomerService : ICrudBaseService<CustomerEntity, CustomerDToEditEntity, Guid>
    {
    }
}
