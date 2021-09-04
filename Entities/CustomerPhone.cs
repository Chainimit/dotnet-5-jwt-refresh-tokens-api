using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WebApi.Entities
{
  public class CustomerPhone
    {
        public int CustomerPhoneId { get; set; }
        public string CustomerId { get; set; }
        public string PhoneId { get; set; }
    }
}