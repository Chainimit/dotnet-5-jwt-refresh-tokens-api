using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class Supplier : Common
    {
        public int SupplierId { get; set; }
        public int Name { get; set; }
    }
}