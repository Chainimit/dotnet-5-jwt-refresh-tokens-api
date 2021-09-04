using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class Product : Common
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}