using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class Phone
    {
        public int PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
    }
}