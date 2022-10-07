using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
    public class Post
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime Date { get; set; }
    }
}