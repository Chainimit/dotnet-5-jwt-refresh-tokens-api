using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class PurchaseOrder : Common
    {
        public int OrderId { get; set; }
        public int OrderNo { get; set; }
        public int CustomerId { get; set; }
        public int SupplierId { get; set; }
        public string Description { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal DiscountPercentage { get; set; }
        public decimal DiscountPrice { get; set; }
        public decimal TotalPrice { get; set; }
        public string Remark { get; set; }
    }
}