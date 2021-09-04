using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class Permission : Common
    {
        public int PermissionId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}