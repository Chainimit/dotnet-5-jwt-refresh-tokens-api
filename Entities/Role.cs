using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class Role : Common
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}