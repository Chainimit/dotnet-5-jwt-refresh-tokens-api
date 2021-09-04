using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class Email
    {
        public int EmailId { get; set; }
        public string EmailAddress { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
    }
}