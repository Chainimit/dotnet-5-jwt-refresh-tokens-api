using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class QuotationOrder
    {
        public int QuotationOrderId { get; set; }
        public int QuotationId { get; set; }
        public int OrderId { get; set; }
    }
}