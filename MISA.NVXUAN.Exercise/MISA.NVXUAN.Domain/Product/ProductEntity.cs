using MISA.NVXUAN.DomainShared.Attributes;
using System;

namespace MISA.NVXUAN.Domain.Product
{
    public class ProductEntity
    {
        /// <summary>
        /// Id sản phẩm
        /// </summary>
        [Key]
        public Guid product_id { get; set; }

        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public string product_code { get; set; }

        /// <summary>
        /// Tên sản phẩm
        /// </summary>
        public string product_name { get; set; }

        /// <summary>
        /// Đơn vị enum ProductUnit
        /// </summary>
        public int product_unit { get; set; }

        /// <summary>
        /// Đơn giá
        /// </summary>
        public double? price { get; set; }

        /// <summary>
        /// Loại hàng hóa
        /// </summary>
        public Guid? product_category_id { get; set; }
    }
}
