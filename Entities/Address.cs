using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
   public class Address
    {
        public int AddressId { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Street { get; set; }
        public string State { get; set; }
        public string Province { get; set; }
        public string PostalCode { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

}