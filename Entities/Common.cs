using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class Common
    {
        public bool IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}