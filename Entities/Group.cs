using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class Group : Common
    {
        public int GroupId { get; set; }
        public int? ParentGroupId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}