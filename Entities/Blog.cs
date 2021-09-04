using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace WebApi.Entities
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public List<Post> Posts { get; set; }
    }

}