using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WebApi.Entities
{
  public class QuotationItem
    {
        public int QuotationItemId { get; set; }
        public string ItemName { get; set; }
        public string ItemDesc { get; set; }
        public int ItemQty { get; set; }
        public int ItemUnitId { get; set; }
        public int ItemPriceId { get; set; }
        public decimal Discount { get; set; }
        public decimal Percentage { get; set; }
        public string Remark { get; set; }
    }
}