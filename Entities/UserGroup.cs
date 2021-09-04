using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class UserGroup
    {
        public int UserGroupId { get; set; }
        public int UserId { get; set; }
        public int GroupId { get; set; }
    }
}