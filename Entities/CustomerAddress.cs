using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WebApi.Entities
{
   public class CustomerAddress
    {
        public int CustomerAddressId { get; set; }
        public int CustomerId { get; set; }
        public int AddressId { get; set; }
        public bool IsDefault { get; set; }
    }
}