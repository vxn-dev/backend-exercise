using Microsoft.AspNetCore.Mvc;
using MISA.NVXUAN.Contracts;
using MISA.NVXUAN.Domain.Customer;
using System;

namespace MISA.NVXUAN.BackendApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : CrudBaseController<ICustomerService, CustomerEntity, CustomerDToEditEntity, Guid>
    {
        public CustomerController(ICustomerService service) : base(service) { }
    }
}
