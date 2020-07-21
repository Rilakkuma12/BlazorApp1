using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class ReceiveKafkaModel
    {
        public DateTime Date { get; set; }

        public string  Topic { get; set; }

        public string Content { get; set; }
    }
}
