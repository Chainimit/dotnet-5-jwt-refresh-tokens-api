using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class CustomerEmail
    {
        public int CustomerEmailId { get; set; }
        public int CustomerId { get; set; }
        public int EmailId { get; set; }
    }
}