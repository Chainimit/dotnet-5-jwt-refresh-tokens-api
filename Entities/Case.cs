using System.Text.Json.Serialization;
using System.Collections.Generic;
using System;

namespace WebApi.Entities
{
    public class Case : Common
    {
        public int CaseId { get; set; }
        public int CustomerId { get; set; }
    }
}