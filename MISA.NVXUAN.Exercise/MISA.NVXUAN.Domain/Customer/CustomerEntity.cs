using System;

namespace MISA.NVXUAN.Domain.Customer
{
    public class CustomerEntity
    {
        /// <summary>
        /// Id khách hàng
        /// </summary>
        [DomainShared.Attributes.Key]
        public Guid customer_id { get; set; }

        /// <summary>
        /// Tên khách hàng
        /// </summary>
        public string customer_name { get; set; }

        /// <summary>
        /// Giới tính 1 Nam | 2 Nữ
        /// </summary>
        public int? gender { get; set; }

        /// <summary>
        /// Thông tin chung
        /// </summary>
        public string description { get; set; }
    }
}
