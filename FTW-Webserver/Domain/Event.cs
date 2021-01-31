using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Event
    {
        public string SenderName { get; set; }
        public DateTime Date { get; set; }
        public string JsonData { get; set; }
    }
}
