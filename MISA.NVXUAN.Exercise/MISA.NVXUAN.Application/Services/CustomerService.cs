using MISA.NVXUAN.Contracts;
using MISA.NVXUAN.Domain.Customer;
using System;
using System.Collections.Generic;
using System.Text;

namespace MISA.NVXUAN.Application
{
    public class CustomerService : CrudBaseService<CustomerEntity, CustomerDToEditEntity, Guid>, ICustomerService
    {
        public CustomerService(IServiceProvider serviceProvider) : base(serviceProvider) { }
    }
}
