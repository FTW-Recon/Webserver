using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Email
    {
        public string Template = @"<h1> User: {{User}}";
        public string Source { get; set; }
        public IEnumerable<string> Destination { get; set; }
        public string Data { get; set; }
    }
}
